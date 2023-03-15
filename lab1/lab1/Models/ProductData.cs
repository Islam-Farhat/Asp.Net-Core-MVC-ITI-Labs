namespace lab1.Models
{
    public static class ProductData
    {
        static List<Product> Products = new List<Product>();
        static ProductData()
        {
            Products.Add(new Product() { id = 1, name = "product1", description = "plaplapla", price = 13.5, image = "1.jpeg" });
            Products.Add(new Product() { id = 2, name = "product2", description = "plaplapla", price = 100, image = "2.jpeg" });
            Products.Add(new Product() { id = 3, name = "product3", description = "plaplapla", price = 200, image = "1.jpeg" });
            Products.Add(new Product() { id = 4, name = "product4", description = "plaplapla", price = 135, image = "2.jpeg" });
            Products.Add(new Product() { id = 5, name = "product5", description = "plaplapla", price = 152, image = "1.jpeg" });
        }

        public static List<Product> getAllProducts()
        {
            return Products;
        }
        public static Product getProductByID(int id)
        {
            var product = Products.FirstOrDefault(x => x.id == id);
            return product;
        }
    }
}
