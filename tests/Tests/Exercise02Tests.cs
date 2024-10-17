using Exercises;

namespace Tests;

public class Exercise02Tests
{
    [Fact]
    public void GetEvenNumbers_ReturnsEvenNumbersInAscendingOrder_WhenCalled()
    {
        // Arrange

        // Act
        var result = Exercise02.GetEvenNumbers();

        // Assert
        var expected = new List<int> { 2, 6, 8 };
        Assert.Equal(expected, result);
    }
}