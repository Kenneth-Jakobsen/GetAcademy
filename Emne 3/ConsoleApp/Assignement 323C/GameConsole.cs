namespace Assignement_323C;

public class GameConsole
{
    public Board board; 
    public GameConsole(Board board)
    {
        this.board = board;
    }
    
    
    public void Show(Board board)
    {
        Console.WriteLine("\n  A B C");
        for (int row = 0; row < 3; row++) 
        {
            Console.Write($"{row + 1} "); 
            for (int col = 0; col < 3; col++) 
            {
                foreach (var square in board._squares)
                {
                    square.State();
                }
            }
            Console.WriteLine(); 
        }
        Console.WriteLine();
    }
}