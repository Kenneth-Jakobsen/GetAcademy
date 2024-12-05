namespace Assignment_323;

public class Match(string myBet)
{
    private  int _homeGoals;
    private  int _awayGoals;
    public  bool IsMatchRunning = true;
    private readonly string? _bet = myBet;


    public void Goal(string input)
    {
        if (input == "H") _homeGoals++;
        else _awayGoals++;
    }
    

    public void GetResult()
    {
        Console.WriteLine(IsMatchRunning
            ? $"The result is {_homeGoals} for Home and {_awayGoals} for Away."
            : $"The end result is {_homeGoals} for Home and {_awayGoals} for Away, your bet was {_bet}.");
    }

    public void EndMatch()
    {
        IsMatchRunning = false;
        GetResult();
    }
    
}