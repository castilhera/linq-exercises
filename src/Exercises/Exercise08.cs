namespace Exercises
{
    public class Exercise08
    {
        // Description:
        // The given LINQ query retrieves a list of employees who have salaries greater than 60,000 but does not group them by their department.
        // Enhance the query to group the employees by their department and order each group by the employee's name.

        public class Employee
        {
            public required string Name { get; set; }
            public required string Department { get; set; }
            public decimal Salary { get; set; }
        }

        public static Dictionary<string, List<Employee>> GetHighEarnersByDepartment()
        {
            List<Employee> employees =
            [
                new() { Name = "John", Department = "HR", Salary = 65000 },
                new() { Name = "Jane", Department = "IT", Salary = 72000 },
                new() { Name = "Joe", Department = "IT", Salary = 58000 },
                new() { Name = "Anna", Department = "HR", Salary = 81000 },
                new() { Name = "Mike", Department = "IT", Salary = 63000 }
            ];

            var highEarners = employees
                .Where(e => e.Salary > 60000)
                .OrderBy(e => e.Name)
                .GroupBy(e => e.Department);

            return highEarners.ToDictionary(g => g.Key, g => g.ToList());
        }
    }
}