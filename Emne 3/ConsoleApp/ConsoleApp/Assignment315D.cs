namespace ConsoleApp;

public class Assignment315D
{
    public static void WordCount()
    {
        Console.WriteLine("Enter a text: ");
        var text = Console.ReadLine();
        var words = text?.Split(" ");
        var wordCount = words!.Length;
        Console.WriteLine($"The word count is {wordCount}");
        var longestWord = FindLongestWord(words);
        Console.WriteLine($"The longest word is {longestWord}");
    }


    public static string FindLongestWord(string[] words)
    {
        var longestWord =" ";
        foreach (var word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        return longestWord;
    }
}