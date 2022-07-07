using DemoAcl.Infrastructure.DTOs;

namespace DemoAcl.Infrastructure.Repositories
{
    public interface IAmazonRepository
    {
        ProductDto GetProductById(string Id);
    }
}
