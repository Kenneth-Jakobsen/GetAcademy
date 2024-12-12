namespace Assignment_323;

public class Match(string? myBet)
{
    private  int _homeGoals;
    private  int _awayGoals;
    public  bool IsMatchRunning = true;


    public void Goal(string input)
    {
        if (input == "H") _homeGoals++;
        else _awayGoals++;
    }
    
    private bool IsBetCorrect()
    {
        var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
        return result == myBet;
    }
    

    public void GetResult()
    {
        var _result=_homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
        var betResult = IsBetCorrect() ? "Wins": "No Wins";
        Console.WriteLine(IsMatchRunning
            ? $"The result is {_homeGoals} for Home and {_awayGoals} for Away."
            : $"The end result is {_homeGoals} for Home and {_awayGoals} for Away, Your bet : {betResult} ");
    }

    public void EndMatch()
    {
        IsMatchRunning = false;
        GetResult();
    }
    
}