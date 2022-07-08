using DemoAcl.Domain.Interfaces;
using DemoAcl.Infrastructure.External;
using DemoAcl.Infrastructure.Repositories;
using DemoAcl.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DemoAcl.Infrastructure
{
    public static class InjectDependencies
    {
        public static void AddInfrastructure(this IServiceCollection services) 
        {
            services.AddScoped<IAmazonRepository, AmazonRepository>();
            services.AddScoped<IShopifyRepository, ShopifyRepository>();
            services.AddScoped<ICountryPriceCalculator<AmazonProduct>, AmazonCountryPriceCalculator>();
            services.AddScoped<IProfitCalculator<ShopifyProduct>, ShopifyProfitCalculator>();
        }
    }
}
