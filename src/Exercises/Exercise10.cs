public class Exercise10
{
    // Description:
    // The given LINQ query retrieves a list of products with a price greater than 100 but does not calculate the total price of these products grouped by their category.
    // Enhance the query to return the total price of products grouped by category.

    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    public static Dictionary<string, decimal> GetTotalPriceByCategory()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1200 },
            new Product { Name = "Headphones", Category = "Electronics", Price = 150 },
            new Product { Name = "Shirt", Category = "Clothing", Price = 50 },
            new Product { Name = "Shoes", Category = "Clothing", Price = 100 },
            new Product { Name = "Refrigerator", Category = "Appliances", Price = 800 }
        };

        return [];
    }
}
