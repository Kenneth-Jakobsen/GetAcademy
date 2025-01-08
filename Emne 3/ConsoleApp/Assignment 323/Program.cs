namespace Assignment_323;

internal static class Program
{
    private static void Main()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      "Hva har du tippet for denne kampen? ");
        var bet = Console.ReadLine();
        var myMatch = new Match(bet);
        while (myMatch.IsMatchRunning)
        {
            Console.Write("Kommandoer: \n" + 
                          " - H = scoring hjemmelag\n" + 
                          " - B = scoring bortelag\n" + 
                          " - X = kampen er ferdig\n" + 
                          "Angi kommando: ");
            var command = Console.ReadLine();
            if (command == "X")
            {
                myMatch.EndMatch();
                break;
            }
            if(command is "H" or "B")myMatch.Goal(command);
            myMatch.GetResult();
        }
    }
}