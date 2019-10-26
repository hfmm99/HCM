using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HCM.Client.GraphQL.Client.Http
{
    internal class GraphQLHttpHandler : IDisposable
    {
        public GraphQLHttpHandler(HttpClient Http, GraphQLHttpClientOptions options)
        {
            this.Options = options ?? throw new ArgumentNullException(nameof(options));
            if (options.EndPoint == null) { throw new ArgumentNullException(nameof(options.EndPoint)); }
            if (options.JsonSerializerSettings == null) { throw new ArgumentNullException(nameof(options.JsonSerializerSettings)); }
            if (options.HttpMessageHandler == null) { throw new ArgumentNullException(nameof(options.HttpMessageHandler)); }
            if (options.MediaType == null) { throw new ArgumentNullException(nameof(options.MediaType)); }

            this.HttpClient = Http;
        }

        public HttpClient HttpClient { get; set; }

        public GraphQLHttpClientOptions Options { get; set; }

        public void Dispose()
        {
            this.Options.HttpMessageHandler.Dispose();
        }

        public async Task<T> GetAsync<T>(string request, CancellationToken cancellationToken = default)
        {
            if (request == null) { throw new ArgumentNullException(nameof(request)); }

            var queryParamsBuilder = new StringBuilder($"query={request}");
            using (var httpResponseMessage = await this.HttpClient.GetAsync($"{this.Options.EndPoint}?{queryParamsBuilder}", cancellationToken).ConfigureAwait(false))
            {
                return await this.ReadHttpResponseMessageAsync<T>(httpResponseMessage).ConfigureAwait(false);
            }
        }

        public async Task<T> PostAsync<T>(string request, Func<string, T> executeOptionalFunc = null, IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default)
        {
            if (request == null) { throw new ArgumentNullException(nameof(request)); }

            using (var httpContent = new StringContent(JObject.FromObject(new { query = request }).ToString()))
            {
                httpContent.Headers.ContentType = this.Options.MediaType;
                httpContent.Headers.Add("Access-Control-Allow-Origin", "*");

                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        httpContent.Headers.Add(header.Key, header.Value);
                    }
                }

                Console.WriteLine($"Executing GraphQL Query ::=  {request}");

                using (var httpResponseMessage = await this.HttpClient.PostAsync(this.Options.EndPoint, httpContent, cancellationToken))
                {
                    return await this.ReadHttpResponseMessageAsync<T>(httpResponseMessage: httpResponseMessage, executeOptionalFunc: executeOptionalFunc).ConfigureAwait(false);
                }
            }
        }

        public async Task<T> ReadHttpResponseMessageAsync<T>(HttpResponseMessage httpResponseMessage, Func<string, T> executeOptionalFunc = null)
        {
            var content = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            return executeOptionalFunc != null ? executeOptionalFunc(content) : JsonConvert.DeserializeObject<T>(content);
        }
    }

}
