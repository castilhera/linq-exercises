namespace Exercises;

public class Exercise07
{
    // Description:
    // The given LINQ query retrieves a list of orders with total amount greater than 1000 but does not sort them by order date.
    // Fix the query to sort the orders by order date in descending order.

    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public static List<Order> GetLargeOrders()
    {
        List<Order> orders =
        [
            new Order { OrderId = 1, OrderDate = new DateTime(2023, 1, 1), TotalAmount = 1200 },
            new Order { OrderId = 2, OrderDate = new DateTime(2023, 2, 1), TotalAmount = 800 },
            new Order { OrderId = 3, OrderDate = new DateTime(2023, 3, 1), TotalAmount = 1500 }
        ];

        var largeOrders = orders
            .Where(o => o.TotalAmount > 1000)
            .OrderByDescending(o => o.OrderDate)
            .ToList();

        return largeOrders;
    }
}