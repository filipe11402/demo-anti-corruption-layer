using DemoAcl.Domain.Interfaces;
using DemoAcl.Infrastructure.DTOs;
using DemoAcl.Infrastructure.Enums;
using DemoAcl.Infrastructure.External;
using ErrorOr;

namespace DemoAcl.Infrastructure.Repositories
{
    public class ShopifyRepository : IShopifyRepository
    {
        private readonly IProfitCalculator<ShopifyProduct> _profitCalculator;

        public ShopifyRepository(IProfitCalculator<ShopifyProduct> profitCalculator)
        {
            _profitCalculator = profitCalculator;
        }

        public ErrorOr<ShopifyProductDto> GetProductById(string Id)
        {
            var shopifyProduct = ShopifyApi.GetProductById(Id);

            if (shopifyProduct is null) { return Error.NotFound(description: ExternalServiceErrorEnum.Generic.ToString()); }

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
