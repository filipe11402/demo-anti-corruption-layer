using DemoAcl.Infrastructure.DTOs;

namespace DemoAcl.Infrastructure.Repositories
{
    public interface IShopifyRepository
    {
        ShopifyProductDto GetProductById(string Id);
    }
}
