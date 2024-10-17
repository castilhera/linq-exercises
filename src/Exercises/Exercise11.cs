public class Exercise11
{
    // Description:
    // The given LINQ query retrieves a list of orders with total amount greater than 1000 but does not return the total amount for each customer.
    // Enhance the query to group the orders by customer and return the total amount spent by each customer.

    public class Order
    {
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public static Dictionary<string, decimal> GetTotalAmountByCustomer()
    {
        List<Order> orders = new List<Order>
        {
            new Order { CustomerName = "Alice", TotalAmount = 1200 },
            new Order { CustomerName = "Bob", TotalAmount = 800 },
            new Order { CustomerName = "Alice", TotalAmount = 1500 },
            new Order { CustomerName = "Bob", TotalAmount = 1000 }
        };

        return new Dictionary<string, decimal>();
    }
}
