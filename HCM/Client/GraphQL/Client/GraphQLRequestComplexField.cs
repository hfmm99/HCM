using System.Linq;

namespace HCM.Client.GraphQL.Client
{
    public class GraphQLRequestComplexField : GraphQLRequestFieldBase
    {
        public GraphQLRequestComplexField(string name, GraphQLRequestFieldBase[] innerObjects) : base(name)
        {
            ParameterValidator.ValidateNotNullParameters(nameof(innerObjects), innerObjects);

            this.InnerObjects = innerObjects;
        }

        public GraphQLRequestFieldBase[] InnerObjects { get; set; }

        public override string RenderField()
        {
            var joinedInnerObjects = this.InnerObjects.Select(innerObject => innerObject.RenderField()).ToList();

            return joinedInnerObjects.Any() ? $"{Name.ToCamelCase()} {{ {joinedInnerObjects.Join(" ")} }}" : Name.ToCamelCase();
        }
    }
}
