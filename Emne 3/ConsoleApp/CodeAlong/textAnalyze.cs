namespace CodeAlong;

public class textAnalyze
{
    private string text;
    private string[] words;
    private string[] letters;
    private string longestWord="";
    private int letterCount;

    public textAnalyze(string text)
    {
        this.text = text;
    }
    

    public string analyzeText()
    {
        int wordCount = 0;
        string[] words = text.Split(" ");
        foreach (var word in words)
        {
            findLongestWord(word);
            countLetters(word);
            wordCount++;
        }
        return ($"Denne teksten har {wordCount} ord, det lengste ordet er {longestWord}. Teksten har {letterCount} ord");
    }

    private string findLongestWord(string word)
    {
        if (word.Length > longestWord.Length)
        {
            var cleantext = cleanText(word);
            if (cleantext.Length > longestWord.Length)
            {
                longestWord = cleantext;
            }
        }
        return longestWord;
    }

    private string cleanText(string text)
    {
        var cleanedText = "";
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                cleanedText += c;
            }
        }
        return cleanedText;
    }
    
    private void countLetters(string word)
    { 
        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                letterCount ++;
            }
        }
    }
}