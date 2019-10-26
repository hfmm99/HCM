using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HCM.Client.GraphQL.Client
{
    public class GraphQLRequest
    {
        public GraphQLRequest(string name, GraphQLRequestArgument[] arguments = null, GraphQLRequestFieldBase[] fields = null)
        {
            InitializeFromCtor(name, arguments, fields);
        }

        public GraphQLRequest(string name, object arguments = null, Type fieldsFrom = null)
        {
            var argsList = new List<GraphQLRequestArgument>();
            if (arguments != null)
            {
                var argsAsDict = arguments.GetType().GetProperties().ToDictionary(x => x.Name, x => x.GetValue(arguments, null));
                foreach (var keyValuePair in argsAsDict)
                {
                    argsList.Add(new GraphQLRequestArgument(keyValuePair.Key, keyValuePair.Value));
                }
            }

            GraphQLRequestFieldBase[] fieldsArray = null;
            if (fieldsFrom != null)
            {
                fieldsArray = fieldsFrom.ToGraphQlRequestFieldBaseArray();
            }

            InitializeFromCtor(name, argsList.ToArray(), fieldsArray);
        }

        public GraphQLRequest(string name, object arguments = null, Func<object, object> fieldsFrom = null, Type typeFieldsFrom = null)
        {
            var argsList = new List<GraphQLRequestArgument>();
            if (arguments != null)
            {
                var argsAsDict = arguments.GetType().GetProperties().ToDictionary(x => x.Name, x => x.GetValue(arguments, null));
                foreach (var keyValuePair in argsAsDict)
                {
                    argsList.Add(new GraphQLRequestArgument(keyValuePair.Key, keyValuePair.Value));
                }
            }

            var fieldsArray = new List<GraphQLRequestFieldBase>();
            if (fieldsFrom != null && typeFieldsFrom != null)
            {
                var defaultObject = DefaultGraphQL(typeFieldsFrom);

                var emptyObject = fieldsFrom(defaultObject);

                if (emptyObject != null)
                {
                    var attributes = emptyObject.GetType().GetProperties();

                    foreach (var attribute in attributes)
                    {
                        if (attribute.GetValue(emptyObject) == null) continue;

                        fieldsArray.Add(new GraphQLRequestBasicField(attribute.Name));

                        if (attribute.PropertyType.IsGenericType && attribute.PropertyType.GetGenericTypeDefinition()
                                .GetInterface("IEnumerable") != null)
                        {
                            AddListObjects(fieldsArray, emptyObject, attribute);
                        }
                        else if (!attribute.PropertyType.IsSealed && attribute.PropertyType.IsClass)
                            AddComplexObjectsFromProp(fieldsArray, attribute, emptyObject);
                    }
                }
                else
                {
                    fieldsArray = typeFieldsFrom.ToGraphQlRequestFieldBaseArray().ToList();
                }
            }

            InitializeFromCtor(name, argsList.ToArray(), fieldsArray.ToArray());
        }

        public List<GraphQLRequestArgument> Arguments { get; set; } = new List<GraphQLRequestArgument>();

        public List<GraphQLRequestFieldBase> Fields { get; set; } = new List<GraphQLRequestFieldBase>();

        public string Name { get; private set; }

        public string RenderRequest()
        {
            var request = new StringBuilder(Name);
            if (Arguments.Any())
            {
                var argList = new List<string>();
                foreach (var argument in Arguments)
                {
                    argList.Add(argument.RenderArgument());
                }

                request.Append($" ( {argList.Join(", ")} )");
            }

            if (Fields.Any())
            {
                var fieldList = new List<string>();
                foreach (var fieldBase in Fields)
                {
                    fieldList.Add(fieldBase.RenderField());
                }

                request.Append($" {{ {fieldList.Join(" ")} }} ");
            }

            return request.ToString();
        }

        /// <summary>Adds complex objects to GraphQL query.</summary>
        /// <param name="fields">The fields to return.</param>
        /// <param name="complexAttribute">The complex object.</param>
        private void AddComplexObjectsFromProp(List<GraphQLRequestFieldBase> fields, PropertyInfo complexAttribute, object rootObject)
        {
            var requestedObject = rootObject.GetType().GetProperty(complexAttribute.Name)?.GetValue(rootObject, null);

            if (requestedObject == null) return;

            var anidatedAttributes = requestedObject.GetType().GetProperties();

            fields.Add(new GraphQLRequestBasicField("{"));
            foreach (var attribute in anidatedAttributes)
            {
                if (attribute.GetValue(requestedObject, null) == null) continue;

                fields.Add(new GraphQLRequestBasicField(attribute.Name));

                if (!attribute.PropertyType.IsSealed && attribute.PropertyType.IsClass)
                    AddComplexObjectsFromProp(fields, attribute, rootObject);
            }
            fields.Add(new GraphQLRequestBasicField("}"));
        }

        private void AddListObjects(List<GraphQLRequestFieldBase> fields, object emptyObject, PropertyInfo attribute)
        {
            var elementInside = emptyObject.GetType().GetProperty(attribute.Name)?.GetValue(emptyObject) as IEnumerable;

            if (elementInside == null) return;

            var enumerator = elementInside.GetEnumerator();
            enumerator.MoveNext();

            var element = enumerator.Current;

            AddSingleObject(fields, element);
        }

        private void AddSingleObject(List<GraphQLRequestFieldBase> fields, object emptyObject)
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

        private object DefaultGraphQL(Type t)
        {
            var result = Activator.CreateInstance(t);

            foreach (var property in result.GetType().GetProperties())
            {
                SetDefaultValues(property, result);
            }

            return result;
        }

        private void InitializeFromCtor(string name, GraphQLRequestArgument[] arguments = null, GraphQLRequestFieldBase[] fields = null)
        {
            this.Name = name;

            if (arguments != null && arguments.Any())
            {
                this.Arguments.AddRange(arguments);
            }

            if (fields != null && fields.Any())
            {
                this.Fields.AddRange(fields);
            }
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
                    property.SetValue(result, Convert.ToDecimal(0));
                    return;
            }

            if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition()
                    .GetInterface("IEnumerable") != null)
            {
                var complexList = Activator.CreateInstance(property.PropertyType);

                var type = complexList.GetType().GetGenericArguments()[0];

                var objectToAdd = DefaultGraphQL(type);

                var methodInfo = complexList.GetType().GetMethod("Add");

                if (methodInfo != null)
                    methodInfo.Invoke(complexList, new[] { objectToAdd });

                property.SetValue(result, complexList);

            }
            else if (property.PropertyType.IsClass)
            {
                property.SetValue(result, DefaultGraphQL(property.PropertyType));
            }
        }
    }
}
