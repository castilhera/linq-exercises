using Exercises;

namespace Tests;

public class Exercise13Tests
{
    [Fact]
    public void GetSalariesByDepartment_ReturnsCorrectMinMaxSalaries_WhenGroupedByDepartment()
    {
        // Arrange

        // Act
        var result = Exercise13.GetSalariesByDepartment();

        // Assert
        var expected = new Dictionary<string, (decimal MinSalary, decimal MaxSalary)>
        {
            { "HR", (50000, 55000) },
            { "IT", (60000, 80000) }
        };

        Assert.Equal(expected, result);
    }
}