namespace DemoAcl.Infrastructure.DTOs
{
    public class ShopifyProductDto
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public double Price { get; private set; }

        public double Profit { get; private set; }

        public ShopifyProductDto(string id, string name, double price, double profit)
        {
            Id = id;
            Name = name;
            Price = price;
            Profit = profit;
        }
    }
}
