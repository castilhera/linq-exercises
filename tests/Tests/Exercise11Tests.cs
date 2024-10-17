public class Exercise11Tests
{
    [Fact]
    public void GetTotalAmountByCustomer_ReturnsCorrectTotalAmountGroupedByCustomer_WhenTotalAmountGreaterThan1000()
    {
        // Arrange

        // Act
        var result = Exercise11.GetTotalAmountByCustomer();

        // Assert
        var expected = new Dictionary<string, decimal>
        {
            { "Alice", 2700 }
        };

        Assert.Equal(expected, result);
    }
}
