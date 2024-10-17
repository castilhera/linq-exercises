public class Exercise4Tests
{
    [Fact]
    public void GetLongWords_ReturnsWordsInDescendingAlphabeticalOrder_WhenLengthIsMoreThanFour()
    {
        // Arrange

        // Act
        var result = Exercise04.GetLongWords();

        // Assert
        var expected = new List<string> { "banana", "apple" };
        Assert.Equal(expected, result);
    }
}
