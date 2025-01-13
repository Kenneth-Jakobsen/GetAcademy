namespace Assignement_323C;

public class GameConsole
{
    public static void Show(Board board)
    {
        Console.WriteLine(board.Squares[0].IsEmpty());
    }
}