namespace Exercises;

public class Exercise02
{
    // Description:
    // The given LINQ query retrieves even numbers from a collection but does not sort them.
    // Fix the query to return the numbers in ascending order.

    public static List<int> GetEvenNumbers()
    {
        List<int> numbers = [8, 3, 5, 6, 2, 7];

        var evenNumbers = numbers
            .Where(n => n % 2 == 0)
            .OrderBy(n => n)
            .ToList();

        return evenNumbers;
    }
}