using System;

namespace ConsoleApplication1
{
    internal class Assignment315GH
    {
        static void Main(string[] arguments)
        {
      
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(text))
            {
                text.ToLower();
                var counts = AsciiCount(text);
                CountCharacters(counts, text);
                break;
            }
        }

        static void CountCharacters(int[] counts, string text)
        {
            for (var i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {   
                    var percentage = ((double)counts[i] / text.Length) * 100;
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i] + " - " + percentage + "%");
                }
            }
        }

        static int[] AsciiCount(string text)
        {
            var counts = new int[250];
            foreach (var character in text)
            {
                counts[(int)character]++;
            }
            return counts;
        }
    }
}