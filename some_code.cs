public class Example
{
    public static void Main()
    {
        string phrase = "Please don't take my bacon.";
        /* Split the phrase into objects using ' ' to separate them, and put those objects into an array */
        string[] words = phrase.Split(' ');

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
        }

        string[] values = {"gloob","90"};
        double number;
        /* Attempt to parse each value in the array; if it cannot be parsed, write an error message in the console. */
        foreach (string value in values) {
            try {
                number = double.Parse(value);
            }
            catch (FormatException) {
                Console.WriteLine("Unable to parse.");
            }
        }
    }
}