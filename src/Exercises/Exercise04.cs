namespace Exercises
{
    public class Exercise04
    {
        // Description:
        // The given LINQ query filters out words with more than 4 characters from a collection but does not sort them.
        // Fix the query to return the words in descending alphabetical order.

        public static List<string> GetLongWords()
        {
            List<string> words = ["apple", "pie", "banana", "kiwi", "plum"];

            var longWords = words
                .Where(w => w.Length > 4)
                .ToList();

            return longWords;
        }
    }
}