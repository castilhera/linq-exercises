using Exercises;

namespace Tests;

public class Exercise05Tests
{
    [Fact]
    public void GetAverageOfNumbersGreaterThan50_ReturnsCorrectAverage_WhenCalled()
    {
        // Arrange

        // Act
        var result = Exercise05.GetAverageOfNumbersGreaterThan50();

        // Assert
        var expected = (60 + 75 + 55) / 3.0;
        Assert.Equal(expected, result, precision: 1);
    }
}