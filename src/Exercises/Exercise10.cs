namespace Exercises;

public class Exercise10
{
    // Description:
    // The given LINQ query retrieves a list of products with a price greater than 100 but does not calculate the total price of these products grouped by their category.
    // Enhance the query to return the total price of products grouped by category.

    public class Product
    {
        public required string Name { get; set; }
        public required string Category { get; set; }
        public decimal Price { get; set; }
    }

    public static Dictionary<string, decimal> GetTotalPriceByCategory()
    {
        List<Product> products =
        [
            new() { Name = "Laptop", Category = "Electronics", Price = 1200 },
            new() { Name = "Headphones", Category = "Electronics", Price = 150 },
            new() { Name = "Shirt", Category = "Clothing", Price = 50 },
            new() { Name = "Shoes", Category = "Clothing", Price = 100 },
            new() { Name = "Refrigerator", Category = "Appliances", Price = 800 }
        ];

        return products
            .Where(p => p.Price > 100)
            .GroupBy(p => p.Category)
            .ToDictionary(g => g.Key, g => g.Sum(p => p.Price));
    }
}