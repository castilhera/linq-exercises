public class Exercise16Tests
{
    [Fact]
    public void GetEmployeeWithMostProjects_ReturnsCorrectEmployee_WhenCalled()
    {
        // Arrange

        // Act
        var result = Exercise16.GetEmployeeWithMostProjects();

        // Assert
        var expected = "John";
        Assert.Equal(expected, result);
    }
}
