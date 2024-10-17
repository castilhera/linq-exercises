public class Exercise3Tests
{
    [Fact]
    public void GetTopStudents_ReturnsNamesInAlphabeticalOrder_WhenMarksAreAbove75()
    {
        // Arrange

        // Act
        var result = Exercise03.GetTopStudents();

        // Assert
        var expected = new List<string> { "Alice", "Charlie" };
        Assert.Equal(expected, result);
    }
}