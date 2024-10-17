public class Exercise16
{
    // Description:
    // The given LINQ query retrieves a list of employees and their projects but does not identify the employee who is involved in the most projects.
    // Enhance the query to find the employee who is involved in the highest number of projects.

    public class Project
    {
        public string EmployeeName { get; set; }
        public string ProjectName { get; set; }
    }

    public static string GetEmployeeWithMostProjects()
    {
        List<Project> projects = new List<Project>
        {
            new Project { EmployeeName = "John", ProjectName = "Project A" },
            new Project { EmployeeName = "Jane", ProjectName = "Project B" },
            new Project { EmployeeName = "John", ProjectName = "Project C" },
            new Project { EmployeeName = "Jane", ProjectName = "Project D" },
            new Project { EmployeeName = "John", ProjectName = "Project E" }
        };

        return string.Empty;
    }
}
