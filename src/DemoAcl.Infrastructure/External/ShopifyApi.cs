namespace DemoAcl.Infrastructure.External
{
    /// <summary>
    /// Fake Shopify API 
    /// </summary>
    public class ShopifyApi
    {
        public static List<ShopifyProduct> _products = new List<ShopifyProduct>() 
        {
            new ShopifyProduct("PhC-1", "Phone cover", 20, "Dropshipping 1", 2),
            new ShopifyProduct("RC-2", "RC car", 100, "Dropshipping 2", 15),
            new ShopifyProduct("CLT-1", "Cleansing Towels", 3, "Dropshipping 2", 0.2),
        };

        public static ShopifyProduct GetProductById(string id)
        {
            return _products.FirstOrDefault(token => token.Id == id);
        }
    }
}
