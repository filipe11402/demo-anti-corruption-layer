using DemoAcl.Infrastructure.DTOs;

namespace DemoAcl.Infrastructure.Repositories
{
    /// <summary>
    /// Read data from Shopify API and return what's needed
    /// </summary>
    public interface IShopifyRepository
    {
        ShopifyProductDto GetProductById(string Id);
    }
}
