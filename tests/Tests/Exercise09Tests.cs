using Exercises;

namespace Tests;

public class Exercise09Tests
{
    [Fact]
    public void GetDailyMaxTemperatures_ReturnsMaxTemperaturesOrderedByDate_WhenCalled()
    {
        // Arrange

        // Act
        var result = Exercise09.GetDailyMaxTemperatures();

        // Assert
        var expected = new List<(DateTime Date, double MaxTemperature)>
        {
            (new DateTime(2023, 1, 1), 34),
            (new DateTime(2023, 1, 2), 30)
        };

        Assert.Equal(expected, result);
    }
}