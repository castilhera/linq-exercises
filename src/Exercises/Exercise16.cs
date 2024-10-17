namespace Exercises;

public class Exercise16
{
    // Description:
    // The given LINQ query retrieves a list of employees and their projects but does not identify the employee who is involved in the most projects.
    // Enhance the query to find the employee who is involved in the highest number of projects.

    public class Project
    {
        public required string EmployeeName { get; set; }
        public required string ProjectName { get; set; }
    }

    public static string GetEmployeeWithMostProjects()
    {
        List<Project> projects =
        [
            new() { EmployeeName = "John", ProjectName = "Project A" },
            new() { EmployeeName = "Jane", ProjectName = "Project B" },
            new() { EmployeeName = "John", ProjectName = "Project C" },
            new() { EmployeeName = "Jane", ProjectName = "Project D" },
            new() { EmployeeName = "John", ProjectName = "Project E" }
        ];

        return string.Empty;
    }
}