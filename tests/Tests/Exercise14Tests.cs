public class Exercise14Tests
{
    [Fact]
    public void GetTop3ProductsByQuantity_ReturnsTop3ProductsByTotalQuantity_WhenCalled()
    {
        // Arrange

        // Act
        var result = Exercise14.GetTop3ProductsByQuantity();

        // Assert
        var expected = new List<(string ProductName, int TotalQuantity)>
        {
            ("Headphones", 20),
            ("Laptop", 20),
            ("Monitor", 15)
        };

        Assert.Equal(expected, result);
    }
}
