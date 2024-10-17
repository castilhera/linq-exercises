﻿public class Exercise8Tests
{
    [Fact]
    public void GetHighEarnersByDepartment_ReturnsGroupedAndOrderedEmployees_WhenSalariesGreaterThan60000()
    {
        // Arrange

        // Act
        var result = Exercise08.GetHighEarnersByDepartment();

        // Assert
        var expected = new Dictionary<string, List<Exercise08.Employee>>
        {
            {
                "HR", new List<Exercise08.Employee>
                {
                    new Exercise08.Employee { Name = "Anna", Department = "HR", Salary = 81000 },
                    new Exercise08.Employee { Name = "John", Department = "HR", Salary = 65000 }
                }
            },
            {
                "IT", new List<Exercise08.Employee>
                {
                    new Exercise08.Employee { Name = "Jane", Department = "IT", Salary = 72000 },
                    new Exercise08.Employee { Name = "Mike", Department = "IT", Salary = 63000 }
                }
            }
        };

        Assert.Equal(expected.Keys, result.Keys);

        foreach (var key in expected.Keys)
        {
            Assert.Equal(expected[key].Select(e => e.Name), result[key].Select(e => e.Name));
        }
    }
}
