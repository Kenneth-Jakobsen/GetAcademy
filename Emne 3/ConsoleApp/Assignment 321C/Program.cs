namespace Assignment_321C;

internal static class Program
{
    static void Main()
    {
        var myCoins = new Coin();
        while (true)
        {
            if (myCoins.SetCoin())
            {
                myCoins.SetAmount();
                myCoins.GetSum();
                break;
            }
            Console.WriteLine("No such coin");
        }
    }
}