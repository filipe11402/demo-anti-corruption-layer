using DemoAcl.Domain.Interfaces;
using DemoAcl.Infrastructure.DTOs;
using DemoAcl.Infrastructure.External;

namespace DemoAcl.Infrastructure.Repositories
{
    public class ShopifyRepository : IShopifyRepository
    {
        private readonly IProfitCalculator<ShopifyProduct> _profitCalculator;

        public ShopifyRepository(IProfitCalculator<ShopifyProduct> profitCalculator)
        {
            _profitCalculator = profitCalculator;
        }

        public ShopifyProductDto GetProductById(string Id)
        {
            var shopifyProduct = ShopifyApi.GetProductById(Id);

            var totalProfit = _profitCalculator.CalculateProfit(shopifyProduct);

            return new ShopifyProductDto(
                shopifyProduct.Id,
                shopifyProduct.Name,
                shopifyProduct.Price,
                totalProfit
                );
        }
    }
}
