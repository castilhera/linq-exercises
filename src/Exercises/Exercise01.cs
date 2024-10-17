namespace Exercises;

public class Exercise01
{
    // Description:
    // The given LINQ query retrieves a list of product names from a collection but does not sort them.
    // Fix the query to return the names in alphabetical order.

    class Product
    {
        public required string Name { get; set; }
    }

    public static IEnumerable<string> GetResult()
    {
        var products = new List<Product>
        {
            new() { Name = "Banana", },
            new() { Name = "Apple", },
            new() { Name = "Cherry", }
        };

        return products.Select(p => p.Name).Order();
    }
}