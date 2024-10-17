using Exercises;

namespace Tests;

public class Exercise07Tests
{
    [Fact]
    public void GetLargeOrders_ReturnsOrdersSortedByOrderDateDesc_WhenTotalAmountGreaterThan1000()
    {
        // Arrange

        // Act
        var result = Exercise07.GetLargeOrders();

        // Assert
        var expected = new List<Exercise07.Order>
    {
        new Exercise07.Order { OrderId = 3, OrderDate = new DateTime(2023, 3, 1), TotalAmount = 1500 },
        new Exercise07.Order { OrderId = 1, OrderDate = new DateTime(2023, 1, 1), TotalAmount = 1200 }
    };

        Assert.Equal(expected.Select(o => o.OrderId), result.Select(o => o.OrderId));
    }
}