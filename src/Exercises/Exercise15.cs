public class Exercise15
{
    // Description:
    // The given LINQ query retrieves a list of student scores but does not calculate the median score for each subject.
    // Enhance the query to group the scores by subject and return the median score for each subject.

    public class Score
    {
        public string Subject { get; set; }
        public int StudentScore { get; set; }
    }

    public static Dictionary<string, double> GetMedianScoreBySubject()
    {
        List<Score> scores = new List<Score>
        {
            new Score { Subject = "Math", StudentScore = 85 },
            new Score { Subject = "Math", StudentScore = 78 },
            new Score { Subject = "Math", StudentScore = 92 },
            new Score { Subject = "Science", StudentScore = 88 },
            new Score { Subject = "Science", StudentScore = 74 },
            new Score { Subject = "Science", StudentScore = 91 }
        };

        return new Dictionary<string, double>();
    }
}
