namespace DemoAcl.Infrastructure.External
{
    public class AmazonProduct
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public double Discount { get; private set; }

        public double PriceWithTax { get; private set; }

        public string SellingCountry { get; set; }

        public AmazonProduct(string id, string name, double discount, double priceWithTax, string sellingCountry)
        {
            Id = id;
            Name = name;
            Discount = discount;
            PriceWithTax = priceWithTax;
            SellingCountry = sellingCountry;
        }
    }
}
