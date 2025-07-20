namespace Exercises;

public class Exercise15
{
    // Description:
    // The given LINQ query retrieves a list of student scores but does not calculate the median score for each subject.
    // Enhance the query to group the scores by subject and return the median score for each subject.

    public class Score
    {
        public required string Subject { get; set; }
        public int StudentScore { get; set; }
    }

    public static double GetMedian(IEnumerable<int> values)
    {
        var valuesCount = values.Count();

        return values
           .OrderBy(v => v)
           .Skip((valuesCount - 1) / 2)
           .Take(2 - valuesCount % 2)
           .Average();
    }

    public static Dictionary<string, double> GetMedianScoreBySubject()
    {
        List<Score> scores =
        [
            new() { Subject = "Math", StudentScore = 85 },
            new() { Subject = "Math", StudentScore = 78 },
            new() { Subject = "Math", StudentScore = 92 },
            new() { Subject = "Science", StudentScore = 88 },
            new() { Subject = "Science", StudentScore = 74 },
            new() { Subject = "Science", StudentScore = 91 }
        ];

        return scores
            .GroupBy(s => s.Subject)
            .ToDictionary(g => g.Key, g => GetMedian(g.Select(s => s.StudentScore)));
    }
}