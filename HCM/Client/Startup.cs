using Ganss.XSS;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace HCM.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazorModal();
            services.AddScoped<IHtmlSanitizer, HtmlSanitizer>(x =>
            {
                /*Configure sanitizer rules as needed here.
                For now, just use default rules + allow class attributes*/
                var sanitizer = new Ganss.XSS.HtmlSanitizer();
                sanitizer.AllowedAttributes.Add("class");
                return sanitizer;
            });
        }


        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
