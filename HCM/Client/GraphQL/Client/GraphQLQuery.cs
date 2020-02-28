using HCM.Client.GraphQL.Client.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace HCM.Client.GraphQL.Client
{
    public class GraphQLQuery<T>
    {
        /// <summary>The GraphQL client service.</summary>
        private IGraphQLClient _graphQlClientService;

        /// <summary>Gets or sets the query method.</summary>
        /// <value>The query method.</value>
        public MethodBase QueryMethod { get; }

        /// <summary>Name of the query based on the QueryMethod.</summary>
        private static string _queryName;

        /// <summary>The GraphQL request to perform.</summary>
        private GraphQLRequest _graphQlRequest;

        /// <summary> Shows if should return an IEnumerable</summary>
        private bool _isIEnumerableResult;

        /// <summary> Wheather the GraphQL Request is a Mutation </summary>
        private bool _isMutation;

        /// <summary>Arguments sent to the Query.</summary>
        public object[] Arguments { get; }

        public Func<T, T> FieldsSelector { get; private set; }

        public Type ElementType => typeof(T);

        Dictionary<string, object> typesDefaultGraphQL;

        /// <summary>Constructor.</summary>
        /// <param name="isIEnumerableResult">Shows if should return an IEnumerable.</param>
        /// <param name="queryMethod">Query method.</param>
        /// <param name="fields">GraphQL HTTP Field Selector Function.</param>
        /// <param name="args">A variable-length parameters list containing arguments.</param>
        public GraphQLQuery(HttpClient httpClient, string endpoint, bool isIEnumerableResult, bool isMutation, MethodBase queryMethod, Func<T, T> fields, params object[] args)
        {
            _graphQlClientService = new GraphQLHttpClient(httpClient, endpoint);
            _isIEnumerableResult = isIEnumerableResult;
            _isMutation = isMutation;
            QueryMethod = queryMethod;
            Arguments = args;
            FieldsSelector = fields;
            typesDefaultGraphQL = new Dictionary<String, Object>();
        }

        public async Task<List<T>> RunAsync(CancellationToken cancellationToken = default)
        {
            //Get GraphQL Query Name
            var graphQlField = QueryMethod.GetCustomAttribute<GraphQLFieldAttribute>();
            _queryName = graphQlField != null && !string.IsNullOrEmpty(graphQlField.FieldName) ? graphQlField.FieldName : QueryMethod.Name;

            //Get GraphQL Query Arguments
            var parameters = QueryMethod.GetParameters();
            var arguments = new List<GraphQLRequestArgument>();
            var fields = new List<GraphQLRequestFieldBase>();

            var items = Arguments.Zip(parameters, (arg, param) => new
            {
                Argument = arg,
                Parameter = param
            }).ToArray();

            foreach (var item in items)
            {
                if (item.Argument != null && !item.Parameter.Name.Equals("sessionToken", StringComparison.InvariantCulture))
                    arguments.Add(new GraphQLRequestArgument(item.Parameter.Name, item.Argument));
            }

            var setPartnerId = items.FirstOrDefault(i => i.Parameter.Name.Equals("partnerId", StringComparison.InvariantCulture));
            var setSessionId = items.FirstOrDefault(i => i.Parameter.Name.Equals("sessionToken", StringComparison.InvariantCulture));

            string path = $"{ _graphQlClientService.EndPoint.Scheme }{ Uri.SchemeDelimiter}{ _graphQlClientService.EndPoint.Authority }{ _graphQlClientService.EndPoint.AbsolutePath }";

            _graphQlClientService.EndPoint = new Uri(path);

            //Get GraphQL Query Fields
            T defaultObject = DefaultGraphQL<T>();

            if (FieldsSelector != null)
            {
                var emptyObject = FieldsSelector(defaultObject);

                if (emptyObject != null)
                {
                    var attributes = emptyObject.GetType().GetProperties();

                    foreach (PropertyInfo attribute in attributes)
                    {
                        if (attribute.GetValue(emptyObject) == null) continue;

                        fields.Add(new GraphQLRequestBasicField(attribute.Name));

                        if (attribute.PropertyType.IsGenericType && attribute.PropertyType.GetGenericTypeDefinition()
                                .GetInterface("IEnumerable") != null)
                        {
                            AddListObjects(fields, emptyObject, attribute);
                        }
                        else if (!attribute.PropertyType.IsSealed && attribute.PropertyType.IsClass)
                            AddComplexObjectsFromProp(fields, attribute, emptyObject);
                    }
                }
            }

            //Build GraphQL Request
            _graphQlRequest = new GraphQLRequest(_queryName, arguments.ToArray(), fields.ToArray());

            //Make HTTP call
            var response = _isMutation
                        ? (_isIEnumerableResult
                           ? await _graphQlClientService.PostMutationAsync(_graphQlRequest, executeOptionalFunc: GetGenericListMethod)
                           : await _graphQlClientService.PostMutationAsync(_graphQlRequest, executeOptionalFunc: GetGenericSingleObjMethod))
                        : (_isIEnumerableResult
                           ? await _graphQlClientService.PostQueryAsync(_graphQlRequest, executeOptionalFunc: GetGenericListMethod)
                           : await _graphQlClientService.PostQueryAsync(_graphQlRequest, executeOptionalFunc: GetGenericSingleObjMethod));

            //Return results
            return response;
        }

        private T DefaultGraphQL<T>()
        {
            return (T)DefaultGraphQL(typeof(T));
        }

        private object DefaultGraphQL(Type t)
        {
            if (typesDefaultGraphQL.ContainsKey(t.FullName))
                return typesDefaultGraphQL[t.FullName];

            //If is String
            if (t == typeof(string))
                return string.Empty;

            //If Is Nullable
            if (typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition() == typeof(Nullable<>))
                return Activator.CreateInstance(Nullable.GetUnderlyingType(typeof(T)));
                
            var result = Activator.CreateInstance(t);
            typesDefaultGraphQL[t.FullName] = result;

            if (t != typeof(string))
            {
                foreach (var property in result.GetType().GetProperties())
                {
                    SetDefaultValues(property, result);
                }
            }

            return result;
        }

        private void SetDefaultValues(PropertyInfo property, object result)
        {
            var propertyType = property.PropertyType.Name.Contains("Null") ? property.PropertyType.GetGenericArguments()[0].Name : property.PropertyType.Name;

            switch (propertyType)
            {
                case "String":
                    property.SetValue(result, string.Empty);
                    return;
                case "DateTime":
                    property.SetValue(result, DateTime.Now);
                    return;
                case "Int32":
                    property.SetValue(result, 0);
                    return;
                case "Int64":
                    property.SetValue(result, default(long));
                    return;
                case "Boolean":
                    property.SetValue(result, true);
                    return;
                case "Decimal":
                    property.SetValue(result, default(decimal));
                    return;
            }

            if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition().GetInterface("IEnumerable") != null)
            {
                object complexList = null;

                if (typesDefaultGraphQL.ContainsKey(property.PropertyType.FullName))
                {
                    complexList = typesDefaultGraphQL[property.PropertyType.FullName];

                    Type type = complexList.GetType().GetGenericArguments()[0];
                }
                else
                {
                    complexList = Activator.CreateInstance(property.PropertyType);

                    Type type = complexList.GetType().GetGenericArguments()[0];

                    var objectToAdd = complexList.GetType().GetGenericArguments()[0].IsClass ? DefaultGraphQL(type) : 0;

                    var methodInfo = complexList.GetType().GetMethod("Add");

                    if (methodInfo != null)
                        methodInfo.Invoke(complexList, new[] { objectToAdd });

                    property.SetValue(result, complexList);

                    typesDefaultGraphQL[property.PropertyType.FullName] = complexList;
                }
            }
            else if (property.PropertyType.IsClass)
            {
                property.SetValue(result, DefaultGraphQL(property.PropertyType));
            }
        }

        /// <summary>Adds complex objects to GraphQL query.</summary>
        /// <param name="fields">The fields to return.</param>
        /// <param name="complexAttribute">The complex object.</param>
        public void AddComplexObjectsFromProp(List<GraphQLRequestFieldBase> fields, PropertyInfo complexAttribute, object rootObject)
        {
            var requestedObject = rootObject.GetType().GetProperty(complexAttribute.Name)?.GetValue(rootObject, null);

            if (requestedObject == null) return;

            var anidatedAttributes = requestedObject.GetType().GetProperties();

            fields.Add(new GraphQLRequestBasicField("{"));
            foreach (var attribute in anidatedAttributes)
            {
                if (attribute.GetValue(requestedObject, null) == null) continue;

                fields.Add(new GraphQLRequestBasicField(attribute.Name));

                if (attribute.PropertyType.IsGenericType && attribute.PropertyType.GetGenericTypeDefinition().GetInterface("IEnumerable") != null)
                {
                    AddListObjects(fields, requestedObject, attribute);
                }
                else if (!attribute.PropertyType.IsSealed && attribute.PropertyType.IsClass)
                    AddComplexObjectsFromProp(fields, attribute, requestedObject);
            }
            fields.Add(new GraphQLRequestBasicField("}"));
        }

        /// <summary>Gets the response string and returns the T element.</summary>
        public Func<string, List<T>> GetGenericListMethod = graphQlGeneric =>
        {
            dynamic dynamicResponse = JObject.Parse(graphQlGeneric);

            var getResult = dynamicResponse["data"]; //TODO: Need to check how to get the data from other schemas, maybe use the Introspection Query
            var result = getResult[_queryName];

            return (List<T>)JsonConvert.DeserializeObject<List<T>>(JsonConvert.SerializeObject(result));
        };

        public Func<string, List<T>> GetGenericSingleObjMethod = graphQlGeneric =>
        {
            dynamic dynamicResponse = JObject.Parse(graphQlGeneric);

            var getResult = dynamicResponse["data"]; //TODO: Need to check how to get the data from other schemas, maybe use the Introspection Query
            var result = getResult[_queryName];

            var serialiceVal = (T)JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(result));

            List<T> response = new List<T>();

            response.Add(serialiceVal);

            return response;
        };

        public void AddListObjects(List<GraphQLRequestFieldBase> fields, object emptyObject, PropertyInfo attribute)
        {
            var elementInside = emptyObject.GetType().GetProperty(attribute.Name)?.GetValue(emptyObject) as IEnumerable;

            if (elementInside == null) return;

            IEnumerator enumerator = elementInside.GetEnumerator();
            enumerator.MoveNext();

            var element = enumerator.Current;

            AddSingleObject(fields, element);
        }

        public void AddSingleObject(List<GraphQLRequestFieldBase> fields, object emptyObject)
        {
            var propertiesObj = emptyObject.GetType().GetProperties();

            fields.Add(new GraphQLRequestBasicField("{"));
            foreach (var attribute in propertiesObj)
            {
                if (attribute.GetValue(emptyObject, null) == null) continue;

                fields.Add(new GraphQLRequestBasicField(attribute.Name));

                if (!attribute.PropertyType.IsSealed && attribute.PropertyType.IsClass)
                    AddComplexObjectsFromProp(fields, attribute, emptyObject);
            }
            fields.Add(new GraphQLRequestBasicField("}"));
        }

        /// <summary>Returns a string that represents the current object, used to debug issues.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return _graphQlRequest != null ? _graphQlRequest.RenderRequest() : string.Empty;
        }
    }
}
