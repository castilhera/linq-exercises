public class Exercise12Tests
{
    [Fact]
    public void GetAveragePriceByCategory_ReturnsCorrectAveragePriceGroupedByCategory_WhenPriceGreaterThan100()
    {
        // Arrange

        // Act
        var result = Exercise12.GetAveragePriceByCategory();

        // Assert
        var expected = new Dictionary<string, decimal>
        {
            { "Electronics", 675 },
            { "Appliances", 800 }
        };

        Assert.Equal(expected, result);
    }
}
