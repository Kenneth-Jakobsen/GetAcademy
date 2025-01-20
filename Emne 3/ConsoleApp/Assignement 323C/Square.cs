namespace Assignement_323C;

public class Square
{
    private  bool _isEmpty = true;
    private string _state = "";

    public bool IsEmpty()
    {
        return _isEmpty;
    }

    public void State()
    { 
        Console.Write(_state);
    }
    

    public void SetState(bool state)
    {
        _state = state ? "X " : "O ";
        _isEmpty = false;
    }
    
}