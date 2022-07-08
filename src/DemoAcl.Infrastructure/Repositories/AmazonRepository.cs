using DemoAcl.Domain.Interfaces;
using DemoAcl.Infrastructure.DTOs;
using DemoAcl.Infrastructure.External;

namespace DemoAcl.Infrastructure.Repositories
{
    public class AmazonRepository : IAmazonRepository
    {
        private readonly ICountryPriceCalculator<AmazonProduct> _calculator;

        public AmazonRepository(ICountryPriceCalculator<AmazonProduct> calculator)
        {
            _calculator = calculator;
        }

        public AmazonProductDto GetProductById(string Id)
        {
            AmazonProduct fetchedAmazonProduct = AmazonApi.GetProductById(Id);

            if (fetchedAmazonProduct is null) { return null; }

            var priceWithNoTax = _calculator.CalculatePriceWithoutTax(fetchedAmazonProduct);

            return new AmazonProductDto(
                fetchedAmazonProduct.Id,
                fetchedAmazonProduct.Name,
                priceWithNoTax
                );
        }
    }
}
