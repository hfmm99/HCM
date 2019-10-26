using System;

namespace HCM.Client.GraphQL.Client
{
    public class GraphQLFieldAttribute : Attribute
    {
        public string FieldName { get; set; }

        public GraphQLFieldAttribute(string fieldName)
        {
            FieldName = fieldName;
        }
    }
}