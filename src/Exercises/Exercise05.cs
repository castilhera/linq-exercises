public class Exercise05
{
    // Description:
    // The given LINQ query filters out numbers greater than 50 from a collection but does not calculate their average.
    // Enhance the query to return the average of the filtered numbers.

    public static double GetAverageOfNumbersGreaterThan50()
    {
        List<int> numbers = new List<int> { 10, 60, 45, 75, 30, 55 };

        var filteredNumbers = numbers.Where(n => n > 50);

        return 0.0;
    }
}
