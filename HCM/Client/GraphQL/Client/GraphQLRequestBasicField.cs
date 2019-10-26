namespace HCM.Client.GraphQL.Client
{
    public class GraphQLRequestBasicField : GraphQLRequestFieldBase
    {
        public GraphQLRequestBasicField(string name) : base(name) { }

        public override string RenderField()
        {
            return this.Name.ToCamelCase();
        }
    }
}
