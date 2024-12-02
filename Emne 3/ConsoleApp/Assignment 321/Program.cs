namespace Assignment_321;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a text");
        string? text = Console.ReadLine();
        Counter.ShowCounts(text);
        
    }
}