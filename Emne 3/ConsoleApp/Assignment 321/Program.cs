namespace Assignment_321;

internal class Program
{
    public static void Main(string[] args)
    {
        var counter = new CharCounter();
        string input="something";
        while (!string.IsNullOrEmpty(input))
        { 
            Console.WriteLine("Enter text: ");
            input = Console.ReadLine();
            counter.AddText(input);
            counter.ShowCounts();
        }
    }
}