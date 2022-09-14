using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TSE.WebApp.MVC.Extensions;
using TSE.WebApp.MVC.Services;

namespace TSE.WebApp.MVC.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}
