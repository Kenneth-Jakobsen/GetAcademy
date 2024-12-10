using System.Runtime.CompilerServices;
namespace Assignment_321;

internal class CharCounter
{
    private string _text = string.Empty;
    private readonly int[] _counts = new int[250];

    public void AddText(string message)
    {
        _text = message;
    }

    public void ShowCounts()
    {
            foreach (var character in _text)
            {
                _counts[character]++;
            }
            for (var i = 0; i < _counts.Length; i++)
            {
                if (_counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + ": " + _counts[i]);
                } 
            }
    }
}