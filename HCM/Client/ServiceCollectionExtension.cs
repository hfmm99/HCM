using HCM.Client.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HCM.Client
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorModal(this IServiceCollection Services)
        {
            return Services.AddScoped<ModalService>();
        }
    }
}