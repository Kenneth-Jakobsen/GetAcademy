namespace Assignement_323C;

public class Board
{
    public Square[] _squares = new Square[9];

    public Board()
    {
        for (var i = 0; i < _squares.Length; i++)
        {
            _squares[i] = new Square();
        }
    }

    public void Mark(string position)
    {
        position = position.ToUpper();
        var column = position[0];
        var row = position[1];
        var colIndex = column - 'A';
        var rowIndex = row - '1';
        var arrayIndex = rowIndex * 3 + colIndex;
        _squares[arrayIndex].SetState(true);
    }
}