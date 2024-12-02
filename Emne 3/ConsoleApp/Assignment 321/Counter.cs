namespace Assignment_321;

public class Counter
{
    public static void ShowCounts(string text)
    {
        var range = 250;
        var counts = new int[range];
        while (!string.IsNullOrWhiteSpace(text))
        {
            foreach (var character in text ?? string.Empty)
            {
                counts[(int)character]++;
            }
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i]);
                }
            }
            break;
        }
    }
}