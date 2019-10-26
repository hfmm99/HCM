using Newtonsoft.Json;
using System;
using System.IO;

namespace HCM.Client.GraphQL.Client
{
    public class GraphQLRequestArgument
    {
        public GraphQLRequestArgument(string name, object value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get; set; }

        public object Value { get; set; }

        public string RenderArgument()
        {
            var valueType = Value?.GetType();

            if (valueType?.IsClass != null)
            {
                var serializer = JsonSerializer.Create(null);
                var stringWriter = new StringWriter();

                using (var jsonWriter = new JsonTextWriter(stringWriter))
                {
                    jsonWriter.QuoteName = false;

                    serializer.Serialize(jsonWriter, Value);
                }

                return $"{Name} : { stringWriter.ToString() } ";
            }

            switch (Value)
            {
                case string _:
                case Guid _:
                    return $"{Name}: \"{Value.ToString().Replace("\"", "\\\"")}\"";
                case null:
                    return $"{Name}: null";
            }

            return $"{Name}: {Value}";
        }
    }
}