using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HCM.Client.GraphQL.Client.Http
{
    public class GraphQLHttpClientOptions
    {
        public Uri EndPoint { get; set; }

        public HttpMessageHandler HttpMessageHandler { get; set; } = new HttpClientHandler();

        public JsonSerializerSettings JsonSerializerSettings { get; set; } = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public MediaTypeHeaderValue MediaType { get; set; } = MediaTypeHeaderValue.Parse("application/json");
    }
}
