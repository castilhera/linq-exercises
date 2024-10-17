using Exercises;

namespace Tests;

public class Exercise01Tests
{
    [Fact]
    public void GetResult_ReturnsNamesInAlphabeticalOrder_WhenCalled()
    {
        // Arrange

        // Act
        var result = Exercise01.GetResult();

        // Assert
        var expected = new List<string> { "Apple", "Banana", "Cherry" };
        Assert.Equal(expected, result.ToList());
    }
}