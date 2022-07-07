namespace DemoAcl.Infrastructure.DTOs
{
    public class AmazonProductDto
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public double Price { get; private set; }

        public AmazonProductDto(string id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
