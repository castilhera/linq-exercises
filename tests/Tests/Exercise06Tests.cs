﻿using Exercises;

namespace Tests;

public class Exercise06Tests
{
    [Fact]
    public void GetExperiencedEmployeeCount_ReturnsCorrectCount_WhenEmployeesHaveMoreThanFiveYears()
    {
        // Arrange

        // Act
        var result = Exercise06.GetExperiencedEmployeeCount();

        // Assert
        var expected = 2;
        Assert.Equal(expected, result);
    }
}