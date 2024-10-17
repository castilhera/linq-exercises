namespace Exercises;

public class Exercise17
{
    // Description:
    // You have a list of students, a list of courses, and a list of enrollments that link students to courses.
    // Each enrollment also includes a score for the student in that course.
    // The given LINQ query retrieves the list of students, but does not calculate the top 3 students based on their average scores across all courses they are enrolled in.
    // Enhance the query to identify and return the top 3 students by their average score.

    public class Student
    {
        public int StudentId { get; set; }
        public required string Name { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public required string CourseName { get; set; }
    }

    public class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Score { get; set; }
    }

    public static List<string> GetTop3StudentsByAverageScore()
    {
        List<Student> students =
        [
            new Student { StudentId = 1, Name = "Alice" },
            new Student { StudentId = 2, Name = "Bob" },
            new Student { StudentId = 3, Name = "Charlie" }
        ];

        List<Course> courses =
        [
            new Course { CourseId = 1, CourseName = "Math" },
            new Course { CourseId = 2, CourseName = "Science" }
        ];

        List<Enrollment> enrollments =
        [
            new Enrollment { StudentId = 1, CourseId = 1, Score = 95 },
            new Enrollment { StudentId = 1, CourseId = 2, Score = 85 },
            new Enrollment { StudentId = 2, CourseId = 1, Score = 80 },
            new Enrollment { StudentId = 2, CourseId = 2, Score = 70 },
            new Enrollment { StudentId = 3, CourseId = 1, Score = 90 },
            new Enrollment { StudentId = 3, CourseId = 2, Score = 60 }
        ];

        return students
            .GroupJoin(enrollments,
                student => student.StudentId,
                enrollment => enrollment.StudentId,
                (student, enrollments) => new
                {
                    StudentName = student.Name,
                    AverageScore = enrollments.Average(e => e.Score),
                    MaxScore = enrollments.Max(e => e.Score)
                })
            .OrderByDescending(s => s.AverageScore)
            .ThenByDescending(s => s.MaxScore)
            .Select(s => s.StudentName)
            .Take(3)
            .ToList();
    }
}