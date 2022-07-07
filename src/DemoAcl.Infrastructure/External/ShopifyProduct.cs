namespace DemoAcl.Infrastructure.External
{
    public class ShopifyProduct
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public double Price { get; private set; }

        public string StoreName { get; private set; }

        public double Comission { get; private set; }

        public ShopifyProduct(string id, string name, double price, string storeName, double comission)
        {
            Id = id;
            Name = name;
            Price = price;
            StoreName = storeName;
            Comission = comission;
        }
    }
}
