// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

public static class Program
{
    private static void Main(string[] args)
    {
        string filePath = "ordliste.txt";
        if(!File.Exists(filePath))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            var textData = File.ReadAllText(filePath);
            string[]splitData = textData.Split('\t');
            for (int i = 0; i < 10; i++)
            {
                Console.Write(splitData[i]);
            }
        } 
        
    }

}