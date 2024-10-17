namespace Exercises;

public class Exercise13
{
    // Description:
    // The given LINQ query retrieves a list of employees but does not identify the highest and lowest salary in each department.
    // Enhance the query to group the employees by department and return the highest and lowest salary in each department.

    public class Employee
    {
        public required string Name { get; set; }
        public required string Department { get; set; }
        public decimal Salary { get; set; }
    }

    public static Dictionary<string, (decimal MinSalary, decimal MaxSalary)> GetSalariesByDepartment()
    {
        List<Employee> employees =
        [
            new() { Name = "John", Department = "HR", Salary = 50000 },
            new() { Name = "Jane", Department = "IT", Salary = 70000 },
            new() { Name = "Joe", Department = "IT", Salary = 60000 },
            new() { Name = "Anna", Department = "HR", Salary = 55000 },
            new() { Name = "Mike", Department = "IT", Salary = 80000 }
        ];

        return employees
            .GroupBy(e => e.Department)
            .ToDictionary(g => g.Key, g => (g.Min(e => e.Salary), g.Max(e => e.Salary)));
    }
}