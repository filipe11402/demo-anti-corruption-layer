namespace DemoAcl.Infrastructure.External
{
    /// <summary>
    /// Fake Amazon API responses
    /// </summary>
    public static class AmazonApi
    {
        private static List<AmazonProduct> _products = new List<AmazonProduct>()
        {
            new AmazonProduct("MyId", "Bench", 20, 200, "Portugal"),
            new AmazonProduct("RC-car1", "RC car", 0, 100, "Spain"),
            new AmazonProduct("LP1", "Laptop", 2, 1000, "Spain")
        };

        public static AmazonProduct GetProductById(string Id) 
        {
            return _products.FirstOrDefault(token => token.Id == Id);
        }
    }
}
