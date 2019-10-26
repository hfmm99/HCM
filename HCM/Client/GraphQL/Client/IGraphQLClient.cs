using HCM.Client.GraphQL.Client.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace HCM.Client.GraphQL.Client
{
    public interface IGraphQLClient : IDisposable
    {
        HttpRequestHeaders DefaultRequestHeaders { get; }

        Uri EndPoint { get; set; }

        GraphQLHttpClientOptions Options { get; set; }

        Task<T> GetQueryAsync<T>(string request, CancellationToken cancellationToken = default);

        Task<T> PostMutationAsync<T>(GraphQLRequest[] requests, IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default);

        Task<T> PostMutationAsync<T>(GraphQLRequest request, IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default);

        Task<T> PostMutationAsync<T>(string name, object arguments, Type fieldsFrom, IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default);

        Task<T> PostQueryAsync<T>(string request, Func<string, T> executeOptionalFunc = null, IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default);

        Task<T> PostQueryAsync<T>(GraphQLRequest[] requests, Func<string, T> executeOptionalFunc = null, IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default);

        Task<T> PostQueryAsync<T>(GraphQLRequest request, Func<string, T> executeOptionalFunc = null, IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default);

        Task<T> PostQueryAsync<T>(string name, object arguments, Type fieldsFrom, IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default);

        Task<T> PostQueryAsync<T, TU>(string name, object arguments, Func<TU, TU> fieldsFrom, IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default);

        Task<T> PostQueryAsync<T>(string name, GraphQLRequestArgument[] arguments, GraphQLRequestFieldBase[] fields, IDictionary<string, IEnumerable<string>> headers = default, CancellationToken cancellationToken = default);
    }
}
