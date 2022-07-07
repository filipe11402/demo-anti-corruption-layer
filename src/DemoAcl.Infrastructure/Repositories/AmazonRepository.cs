using DemoAcl.Infrastructure.Abstract;
using DemoAcl.Infrastructure.DTOs;
using DemoAcl.Infrastructure.External;

namespace DemoAcl.Infrastructure.Repositories
{
    public class AmazonRepository : IAmazonRepository
    {
        private readonly ICountryPriceCalculator _calculator;

        public AmazonRepository(ICountryPriceCalculator calculator)
        {
            _calculator = calculator;
        }

        public ProductDto GetProductById(string Id)
        {
            AmazonProduct fetchedAmazonProduct = AmazonApi.GetProductById(Id);

            double priceWithNoTax = _calculator.CalculatePriceWithoutTax(fetchedAmazonProduct);

            var product = new ProductDto(
                fetchedAmazonProduct.Id,
                fetchedAmazonProduct.Name,
                priceWithNoTax);

            return product;
        }
    }
}
