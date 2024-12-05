namespace Assignment_323;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      " - halvgardering: HU, HB, UB\n" + 
                      " - helgardering: HUB\n" + 
                      "Hva har du tippet for denne kampen? ");
        string bet = Console.ReadLine();
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
            if(command == "H" || command == "B")myMatch.Goal(command);
            myMatch.GetResult();
        }
        
    }
}