namespace Exercises
{
    public class Exercise09
    {
        // Description:
        // The given LINQ query retrieves the maximum temperature recorded each day but does not order the results.
        // Enhance the query to return the results ordered by date.

        public class TemperatureRecord
        {
            public DateTime Date { get; set; }
            public double Temperature { get; set; }
        }

        public static List<(DateTime Date, double MaxTemperature)> GetDailyMaxTemperatures()
        {
            List<TemperatureRecord> records =
            [
                new() { Date = new DateTime(2023, 1, 1), Temperature = 32 },
                new() { Date = new DateTime(2023, 1, 1), Temperature = 34 },
                new() { Date = new DateTime(2023, 1, 2), Temperature = 30 },
                new() { Date = new DateTime(2023, 1, 2), Temperature = 28 }
            ];

            return records
                .GroupBy(r => r.Date)
                .Select(g => (g.Key, g.Max(r => r.Temperature)))
                .ToList();
        }
    }
}