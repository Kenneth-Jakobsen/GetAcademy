namespace OrdGaate;

public static class Program
{
    private static readonly Random Random = new Random();
    private static void Main(string[] args)
    {
        
        string filePath = "ordliste.txt";
        string[] words = GetWords(filePath);
        var wordCount = 0;
        while (wordCount < 200)
        {
            FindMatch(words);
            Console.WriteLine($"Found {wordCount} words");
            wordCount++;
        }
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
                words.Add(word);
            }
        }
        return words.ToArray();
    }

    static void FindMatch(string[] words)
    {
      var randomIndex = Random.Next(words.Length);
      var randomWord = words[randomIndex];
      foreach (var word in words)
      {
          if (IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(randomWord, word))
          {
              Console.WriteLine($"Word: {randomWord} - {word.Substring(0,3)} - {word}");
              return;
          }
          
      }
    }

    
    private static bool IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(string word1, string word2)
    {
        var lastPartOfFirstWord = word1.Substring(word1.Length-3);
        var firstPartOfSecondWord = word2.Substring(0,3);
        return lastPartOfFirstWord == firstPartOfSecondWord;
    }


}