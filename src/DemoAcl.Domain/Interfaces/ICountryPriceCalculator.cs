namespace DemoAcl.Domain.Interfaces
{
    public interface ICountryPriceCalculator<T> where T : class
    {
        double CalculatePriceWithoutTax(T product);
    }
}
