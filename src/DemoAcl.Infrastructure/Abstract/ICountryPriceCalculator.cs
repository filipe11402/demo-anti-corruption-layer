using DemoAcl.Infrastructure.External;

namespace DemoAcl.Infrastructure.Abstract
{
    public interface ICountryPriceCalculator
    {
        double CalculatePriceWithoutTax(
            AmazonProduct product
            );
    }
}
