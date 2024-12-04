using System.Runtime.CompilerServices;
namespace Assignment_321;

internal class CharCounter
{
    private string text = string.Empty;
    private int[] counts = new int[250];

    public void AddText(string message)
    {
        text = message;
    }

    public void ShowCounts()
    {
            foreach (var character in text)
            {
                counts[character]++;
            }
            for (var i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + ": " + counts[i]);
                } 
            }
    }
}