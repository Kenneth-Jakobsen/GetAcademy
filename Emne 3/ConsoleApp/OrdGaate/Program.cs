namespace OrdGaate;

public static class Program
{
    private static void Main(string[] args)
    { 
        
        string filePath = "ordliste.txt";
       string[] words = GetWords(filePath);
       FindMatch(words);
    }

    static string[] GetWords(string args)
    {
        var textData = File.ReadAllLines(args);
        var words = new List<string>();
        foreach(var line in textData)
        {
            var word = line.Split('\t')[1];
            if (!words.Contains(word) 
                && word.Length is > 6 and < 10
                && !word.Contains('-'))
            {
                var lastThreeLetters = word.Length - 3;
                Console.WriteLine($"Word: {word}, lastLetters:{word.Substring(lastThreeLetters)}");
                words.Add(word);
            }
        }
        return words.ToArray();
    }

    static string[] FindMatch(string[] words)
    {
        return [""];
    }

}