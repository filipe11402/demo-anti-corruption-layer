using DemoAcl.Domain.Interfaces;
using DemoAcl.Infrastructure.External;

namespace DemoAcl.Infrastructure.Services
{
    public class ShopifyProfitCalculator : IProfitCalculator<ShopifyProduct>
    {
        public double CalculateProfit(ShopifyProduct product)
        {
            return product.Price - product.Comission;
        }
    }
}