using Microsoft.Extensions.DependencyInjection;
using BlazorApp.Dependencies;

namespace BlazorApp.Services
{
    public class Services
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISingleton, RandomNumber>();
            services.AddTransient<IScoped, RandomNumber>();
            services.AddScoped<ITransient, RandomNumber>();
        }
    }
}