using Exercises;

namespace Tests;

public class Exercise15Tests
{
    [Fact]
    public void GetMedianScoreBySubject_ReturnsCorrectMedianScoreGroupedBySubject_WhenCalled()
    {
        // Arrange

        // Act
        var result = Exercise15.GetMedianScoreBySubject();

        // Assert
        var expected = new Dictionary<string, double>
        {
            { "Math", 85 },
            { "Science", 88 }
        };

        Assert.Equal(expected, result);
    }
}