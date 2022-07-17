using DemoAcl.Infrastructure.DTOs;
using ErrorOr;

namespace DemoAcl.Infrastructure.Repositories
{
    /// <summary>
    /// Read data from Amazon API and return what's needed
    /// </summary>
    public interface IAmazonRepository
    {
        ErrorOr<AmazonProductDto> GetProductById(string Id);
    }
}
