public class Exercise03
{
    // Description:
    // The given LINQ query retrieves a list of student names who scored more than 75 marks but does not sort them.
    // Fix the query to return the names in alphabetical order.

    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    public static List<string> GetTopStudents()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Charlie", Marks = 78 },
            new Student { Name = "Alice", Marks = 85 },
            new Student { Name = "Bob", Marks = 65 },
        };

        var topStudents = students.Where(s => s.Marks > 75).Select(s => s.Name).ToList();

        return topStudents;
    }
}
