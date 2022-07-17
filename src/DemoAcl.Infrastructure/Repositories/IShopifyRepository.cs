using DemoAcl.Infrastructure.DTOs;
using ErrorOr;

namespace DemoAcl.Infrastructure.Repositories
{
    /// <summary>
    /// Read data from Shopify API and return what's needed
    /// </summary>
    public interface IShopifyRepository
    {
        ErrorOr<ShopifyProductDto> GetProductById(string Id);
    }
}
