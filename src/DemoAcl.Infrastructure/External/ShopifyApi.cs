namespace DemoAcl.Infrastructure.External
{
    /// <summary>
    /// Fake Shopify API 
    /// </summary>
    public class ShopifyApi
    {
        public static List<ShopifyProduct> _products = new List<ShopifyProduct>() 
        {
            new ShopifyProduct(Guid.NewGuid().ToString(), "Phone cover", 20, "Dropshipping 1", 2),
            new ShopifyProduct(Guid.NewGuid().ToString(), "RC car", 100, "Dropshipping 2", 15),
            new ShopifyProduct(Guid.NewGuid().ToString(), "Cleansing Towels", 3, "Dropshipping 2", 0.2),
        };

        public static ShopifyProduct GetProductById(string id)
        {
            return _products.FirstOrDefault(token => token.Id == id);
        }
    }
}
