namespace Assignement_323C;

public class Board
{
    private Square[] _squares = new Square[9];


    public void Mark(string position)
    {
        var column = position[0];
        var row = position[1];
        var colIndex = column - 'A';
        var rowIndex = row - '1';
        var arrayIndex = rowIndex * 3 + colIndex;
        _squares[arrayIndex].SetState(true);
    }
}