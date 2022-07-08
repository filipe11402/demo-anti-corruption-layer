using DemoAcl.Infrastructure.DTOs;

namespace DemoAcl.Infrastructure.Repositories
{
    /// <summary>
    /// Read data from Amazon API and return what's needed
    /// </summary>
    public interface IAmazonRepository
    {
        AmazonProductDto GetProductById(string Id);
    }
}
