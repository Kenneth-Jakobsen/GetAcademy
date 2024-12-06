namespace OrdGaate;

public static class Program
{
    private static readonly Random Random = new Random();
    private static void Main(string[] args)
    {
        
        const string filePath = "ordliste.txt";
        var words = GetWords(filePath);
        var wordCount = 0;
        
        while (wordCount <200)
        {
            var randomWord = words[Random.Next(0, words.Length)];
            var word = FindMatch(words, randomWord);
            if (word.Length > 0)
            { 
                wordCount++;
                Console.WriteLine($"{randomWord} - {randomWord[^3..]} - {word}  - {wordCount} Words");
                
            }
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

    static string FindMatch(string[] words, string randomWord )
    {
        var word = words[Random.Next(0, words.Length)];
   
          if (IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(randomWord, word))
          {
              return word ;
          }
          return "";
    }

    
    private static bool IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(string word1, string word2)
    {
        var lastPartOfFirstWord = word1[^3..];
        var firstPartOfSecondWord = word2[..3];
        return lastPartOfFirstWord == firstPartOfSecondWord;
    }


}