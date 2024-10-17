namespace Exercises;

public class Exercise11
{
    // Description:
    // The given LINQ query retrieves a list of orders with total amount greater than 1000 but does not return the total amount for each customer.
    // Enhance the query to group the orders by customer and return the total amount spent by each customer.

    public class Order
    {
        public required string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public static Dictionary<string, decimal> GetTotalAmountByCustomer()
    {
        List<Order> orders =
        [
            new() { CustomerName = "Alice", TotalAmount = 1200 },
            new() { CustomerName = "Bob", TotalAmount = 800 },
            new() { CustomerName = "Alice", TotalAmount = 1500 },
            new() { CustomerName = "Bob", TotalAmount = 1000 }
        ];

        return orders
            .Where(o => o.TotalAmount > 1000)
            .GroupBy(o => o.CustomerName)
            .ToDictionary(g => g.Key, g => g.Sum(o => o.TotalAmount));
    }
}