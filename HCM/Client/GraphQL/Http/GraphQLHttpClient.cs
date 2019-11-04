using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace HCM.Client.GraphQL.Client.Http
{
    public sealed class GraphQLHttpClient : IGraphQLClient
    {
        internal readonly GraphQLHttpHandler graphQlHttpHandler;

        public GraphQLHttpClient(HttpClient httpClient, string endPoint) : this(httpClient, new Uri(endPoint)) { }

        private GraphQLHttpClient(HttpClient httpClient, Uri endPoint) : this(httpClient, new GraphQLHttpClientOptions { EndPoint = endPoint }) { }

        private GraphQLHttpClient(HttpClient httpClient, string endPoint, GraphQLHttpClientOptions options) : this(httpClient, new Uri(endPoint), options) { }

        private GraphQLHttpClient(HttpClient httpClient, Uri endPoint, GraphQLHttpClientOptions options)
        {
            if (options == null) { throw new ArgumentNullException(nameof(options)); }
            if (options.EndPoint == null) { throw new ArgumentNullException(nameof(options.EndPoint)); }
            if (options.JsonSerializerSettings == null) { throw new ArgumentNullException(nameof(options.JsonSerializerSettings)); }
            if (options.HttpMessageHandler == null) { throw new ArgumentNullException(nameof(options.HttpMessageHandler)); }
            if (options.MediaType == null) { throw new ArgumentNullException(nameof(options.MediaType)); }

            options.EndPoint = endPoint ?? throw new ArgumentNullException(nameof(endPoint));
            this.graphQlHttpHandler = new GraphQLHttpHandler(httpClient, options);
        }

        private GraphQLHttpClient(HttpClient httpClient, GraphQLHttpClientOptions options)
        {
            this.HttpClient = httpClient;

            if (options == null) { throw new ArgumentNullException(nameof(options)); }
            if (options.EndPoint == null) { throw new ArgumentNullException(nameof(options.EndPoint)); }
            if (options.JsonSerializerSettings == null) { throw new ArgumentNullException(nameof(options.JsonSerializerSettings)); }
            if (options.HttpMessageHandler == null) { throw new ArgumentNullException(nameof(options.HttpMessageHandler)); }
            if (options.MediaType == null) { throw new ArgumentNullException(nameof(options.MediaType)); }

            this.graphQlHttpHandler = new GraphQLHttpHandler(httpClient, options);
        }

        public HttpClient HttpClient { get; private set; }

        public HttpRequestHeaders DefaultRequestHeaders => HttpClient.DefaultRequestHeaders;

        public Uri EndPoint
        {
            get => this.Options.EndPoint;
            set => this.Options.EndPoint = value;
        }

        public GraphQLHttpClientOptions Options
        {
            get => this.graphQlHttpHandler.Options;
            set => this.graphQlHttpHandler.Options = value;
        }

        public void Dispose() => this.graphQlHttpHandler.Dispose();

        public async Task<T> GetQueryAsync<T>(string request, CancellationToken cancellationToken = default)
        {
            return await this.graphQlHttpHandler.GetAsync<T>(request, cancellationToken).ConfigureAwait(false);
        }

        public async Task<T> PostMutationAsync<T>(GraphQLRequest[] requests, Func<string, T> executeOptionalFunc = null,
            IDictionary<string, IEnumerable<string>> headers = default, 
            CancellationToken cancellationToken = default)
        {
            if (requests == null) throw new ArgumentNullException(nameof(requests));

            var requestsRendered = requests.Select(request => request.RenderRequest()).ToList().Join("\n");

            return await PostQueryAsync<T>(request: $"mutation {{ {requestsRendered} }}", executeOptionalFunc: executeOptionalFunc, headers: headers, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        public async Task<T> PostMutationAsync<T>(GraphQLRequest request, Func<string, T> executeOptionalFunc = null,
            IDictionary<string, IEnumerable<string>> headers = default, 
            CancellationToken cancellationToken = default)
        {
            return await this.PostMutationAsync<T>(requests: new[] { request }, executeOptionalFunc: executeOptionalFunc, headers: headers, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        public async Task<T> PostMutationAsync<T>(string name, object arguments, Type fieldsFrom,
            Func<string, T> executeOptionalFunc = null, IDictionary<string, IEnumerable<string>> headers = default, 
            CancellationToken cancellationToken = default)
        {
            return await this.PostMutationAsync<T>(request: new GraphQLRequest(name, arguments, fieldsFrom), executeOptionalFunc: executeOptionalFunc, headers: headers, cancellationToken: cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<T> PostQueryAsync<T>(string request, Func<string, T> executeOptionalFunc = null,
            IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default)
        {
            return await this.graphQlHttpHandler.PostAsync<T>(request: request, executeOptionalFunc: executeOptionalFunc, headers: headers, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        public async Task<T> PostQueryAsync<T>(GraphQLRequest[] requests, Func<string, T> executeOptionalFunc = null,
            IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default)
        {
            if (requests == null) throw new ArgumentNullException(nameof(requests));

            var requestsRendered = requests.Select(request => request.RenderRequest()).ToList().Join("\n");

            return await PostQueryAsync(request: $"{{ {requestsRendered} }}", executeOptionalFunc: executeOptionalFunc, headers: headers, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        public async Task<T> PostQueryAsync<T>(GraphQLRequest request, Func<string, T> executeOptionalFunc = null,
            IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default)
        {
            return await PostQueryAsync(requests: new[] { request }, executeOptionalFunc: executeOptionalFunc, headers: headers, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        public async Task<T> PostQueryAsync<T>(string name, object arguments, Type fieldsFrom,
            IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default)
        {
            return await PostQueryAsync<T>(request: new GraphQLRequest(name, arguments, fieldsFrom), headers: headers, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        public async Task<T> PostQueryAsync<T, TU>(string name, object arguments, Func<TU, TU> fieldsFrom,
            IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default)
        {
            object FieldFormWrapper(object o)
            {
                if (fieldsFrom != null)
                {
                    return fieldsFrom((TU)o);
                }

                return null;
            }

            return await PostQueryAsync<T>(request: new GraphQLRequest(name, arguments, FieldFormWrapper, typeof(TU)), headers: headers, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        public async Task<T> PostQueryAsync<T>(string name, GraphQLRequestArgument[] arguments, GraphQLRequestFieldBase[] fields, IDictionary<string, IEnumerable<string>> headers = default,
            CancellationToken cancellationToken = default)
        {
            return await PostQueryAsync<T>(request: new GraphQLRequest(name, arguments, fields), headers: headers, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }

}
