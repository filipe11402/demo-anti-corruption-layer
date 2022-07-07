namespace DemoAcl.Domain.Interfaces
{
    public interface IProfitCalculator<T> where T : class
    {
        double CalculateProfit(T product);
    }
}
