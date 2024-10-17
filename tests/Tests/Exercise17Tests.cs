using Exercises;

namespace Tests;

public class Exercise17Tests
{
    [Fact]
    public void GetTop3StudentsByAverageScore_ReturnsCorrectTop3Students_WhenCalled()
    {
        // Arrange

        // Act
        var result = Exercise17.GetTop3StudentsByAverageScore();

        // Assert
        var expected = new List<string> { "Alice", "Charlie", "Bob" };

        Assert.Equal(expected, result);
    }
}