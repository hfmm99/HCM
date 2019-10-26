namespace HCM.Client.GraphQL.Client
{
    public abstract class GraphQLRequestFieldBase
    {
        protected GraphQLRequestFieldBase(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public abstract string RenderField();
    }
}