namespace Exercises;

public class Exercise06
{
    // Description:
    // The given LINQ query filters employees who have been with the company for more than 5 years but does not count them.
    // Enhance the query to return the count of such employees.

    public class Employee
    {
        public required string Name { get; set; }
        public int YearsWithCompany { get; set; }
    }

    public static int GetExperiencedEmployeeCount()
    {
        List<Employee> employees =
        [
            new Employee { Name = "John", YearsWithCompany = 6 },
            new Employee { Name = "Jane", YearsWithCompany = 4 },
            new Employee { Name = "Joe", YearsWithCompany = 7 }
        ];

        var experiencedEmployees = employees
            .Where(e => e.YearsWithCompany > 5);

        return 0;
    }
}