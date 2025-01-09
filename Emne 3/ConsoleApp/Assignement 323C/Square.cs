namespace Assignement_323C;

public class Square
{
    private bool _isEmpty = true;
    private string _state = string.Empty;

    public bool IsEmpty()
    {
        return _isEmpty;
    }

    public string State()
    {
        return _state;
    }

    public void SetState(bool state)
    {
        if (!_isEmpty)
        {
            _state = state ? "player 1" : "player 2";
        }
    }
    
}