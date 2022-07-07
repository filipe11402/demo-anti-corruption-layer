using DemoAcl.Infrastructure.Abstract;
using DemoAcl.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DemoAcl.Infrastructure
{
    public static class InjectDependencies
    {
        public static void AddInfrastructure(this IServiceCollection services) 
        {
            services.AddScoped<IAmazonRepository, AmazonRepository>();
            services.AddScoped<ICountryPriceCalculator, CountryPriceCalculator>();
        }
    }
}
