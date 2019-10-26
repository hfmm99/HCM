using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCM.Client.GraphQL.Client
{
    internal static class TypeExtensions
    {
        public static GraphQLRequestFieldBase[] ToGraphQlRequestFieldBaseArray(this Type type)
        {
            var result = new List<GraphQLRequestFieldBase>();

            foreach (var propertyInfo in type.GetProperties())
            {
                var inferedType = propertyInfo.PropertyType;

                if (typeof(IEnumerable).IsAssignableFrom(inferedType))
                {
                    if (propertyInfo.PropertyType.IsGenericType)
                    {
                        inferedType = propertyInfo.PropertyType.GetGenericArguments().FirstOrDefault();
                        if (inferedType == null)
                        {
                            throw new ArgumentOutOfRangeException(nameof(type), "Not all the generic types are complete");
                        }
                    }

                    if (inferedType.IsArray)
                    {
                        inferedType = propertyInfo.PropertyType.GetElementType();
                    }
                }

                if (inferedType.IsValueType || inferedType == typeof(string))
                {
                    result.Add(new GraphQLRequestBasicField(propertyInfo.Name));
                }
                else
                {
                    result.Add(new GraphQLRequestComplexField(propertyInfo.Name, inferedType.ToGraphQlRequestFieldBaseArray()));
                }

            }

            return result.ToArray();
        }

        /// <summary>
        /// Join each item in the collection together with the glue string, returning a single string
        /// Each object in the collection will be converted to string with ToString()
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="glue"></param>
        /// <returns></returns>
        public static string Join(this ICollection collection, string glue)
        {
            string returnVal = null;
            if (collection != null)
            {
                foreach (object o in collection)
                {
                    if (returnVal == null)
                    {
                        returnVal = o.ToString();
                    }
                    else
                    {
                        returnVal = returnVal + glue + o;
                    }
                }
            }
            return returnVal;
        }

        public static string ToCamelCase(this string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Length > 1)
            {
                return char.ToLowerInvariant(str[0]) + str.Substring(1);
            }

            return str;
        }
    }
}
