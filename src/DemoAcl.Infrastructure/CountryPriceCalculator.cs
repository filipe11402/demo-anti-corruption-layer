using DemoAcl.Infrastructure.Abstract;
using DemoAcl.Infrastructure.External;

namespace DemoAcl.Infrastructure
{
    public class CountryPriceCalculator : ICountryPriceCalculator
    {
        private const string Portugal = "Portugal";
        private const string Spain = "Spain";

        public double CalculatePriceWithoutTax(AmazonProduct product)
        {
            return product.SellingCountry switch
            {
                Portugal => product.PriceWithTax - (product.PriceWithTax * 0.23),
                Spain => product.PriceWithTax - (product.PriceWithTax * 0.11),
                _ => product.PriceWithTax,
            };
        }
    }
}
