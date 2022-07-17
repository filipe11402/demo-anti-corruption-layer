using DemoAcl.Domain.Interfaces;
using DemoAcl.Infrastructure.DTOs;
using DemoAcl.Infrastructure.Enums;
using DemoAcl.Infrastructure.External;
using ErrorOr;

namespace DemoAcl.Infrastructure.Repositories
{
    public class AmazonRepository : IAmazonRepository
    {
        private readonly ICountryPriceCalculator<AmazonProduct> _calculator;

        public AmazonRepository(ICountryPriceCalculator<AmazonProduct> calculator)
        {
            _calculator = calculator;
        }

        public ErrorOr<AmazonProductDto> GetProductById(string Id)
        {
            AmazonProduct fetchedAmazonProduct = AmazonApi.GetProductById(Id);

            if (fetchedAmazonProduct is null) { return Error.NotFound(description: ExternalServiceErrorEnum.Generic.ToString()); }

            var priceWithNoTax = _calculator.CalculatePriceWithoutTax(fetchedAmazonProduct);

            return new AmazonProductDto(
                fetchedAmazonProduct.Id,
                fetchedAmazonProduct.Name,
                priceWithNoTax
                );
        }
    }
}
