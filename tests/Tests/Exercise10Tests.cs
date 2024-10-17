public class Exercise10Tests
{
    [Fact]
    public void GetTotalPriceByCategory_ReturnsCorrectTotalPriceGroupedByCategory_WhenPriceGreaterThan100()
    {
        // Arrange

        // Act
        var result = Exercise10.GetTotalPriceByCategory();

        // Assert
        var expected = new Dictionary<string, decimal>
        {
            { "Electronics", 1350 },
            { "Appliances", 800 }
        };

        Assert.Equal(expected, result);
    }
}
