namespace ConsoleApp;

public static class Assignment315C
{
   public static void Run()
    { 
        Console.WriteLine("Enter a text"); 
        var word = Console.ReadLine();
        var charArray = word?.ToCharArray();
        Array.Reverse(charArray);
        var reversedWord = new string(charArray);
        
        Console.WriteLine($"The reverse of '{word}' is '{reversedWord}' ");
    }
} 