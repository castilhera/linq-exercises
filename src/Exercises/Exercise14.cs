namespace Exercises;

public class Exercise14
{
    // Description:
    // The given LINQ query retrieves a list of orders with their quantities but does not return the top 3 products by total quantity ordered.
    // Enhance the query to return the top 3 products based on the total quantity ordered.

    public class Order
    {
        public required string ProductName { get; set; }
        public int Quantity { get; set; }
    }

    public static List<(string ProductName, int TotalQuantity)> GetTop3ProductsByQuantity()
    {
        List<Order> orders =
        [
            new() { ProductName = "Laptop", Quantity = 5 },
            new() { ProductName = "Headphones", Quantity = 20 },
            new() { ProductName = "Laptop", Quantity = 15 },
            new() { ProductName = "Monitor", Quantity = 10 },
            new() { ProductName = "Monitor", Quantity = 5 }
        ];

        return [];
    }
}