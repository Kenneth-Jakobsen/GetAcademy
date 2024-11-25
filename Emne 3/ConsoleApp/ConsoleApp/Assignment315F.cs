namespace ConsoleApp;

public class Assignment315F
{
    private static readonly int[] numbersArray = GenerateArray();
    
    public static void Run()
    {
        Console.WriteLine("Lets play a game, Y/N");
        string? input = Console.ReadLine();
        input = input?.ToLower();
        if (input == "y")
        {
            DrawBoard();
            MovePiece();
        }
        else
        {
            Console.WriteLine("Game Over");
        }
    }

    public static void DrawBoard()
    {
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.Write((numbersArray[i] == 9 ? $"{' ',-3}":$"{numbersArray[i],-3}")); 
            if ((i + 1) % 3 == 0)
            {
                Console.WriteLine();
            }
        }
    }

    public static void MovePiece()
    {
        Console.WriteLine("Choose a number to move to the empty space.");
        var userInput = Console.ReadLine();
        var userMove = Convert.ToInt32(userInput);
        int[] possibleMoves = {userMove -3, userMove-1,userMove+1,userMove-3};
        possibleMoves = RemoveInvalidIndexes(possibleMoves);
        if (Array.Exists(possibleMoves, move => move == userMove))
        {
            Console.WriteLine($"Move {userMove} to the empty space.");
        }
        else
        {
            Console.WriteLine($"Move {userMove} is invalid. Try again.");
        }
    }

    public static int[] RemoveInvalidIndexes(int[] array)
    {
        var validList = new List<int>(array);
        validList.RemoveAll(item => item < 0 || item > 8);
        var validArray = validList.ToArray();
        return validList.ToArray();
    }
    
    
    private static int[] GenerateArray()
    {
        var rand = new Random();
        var array = new int[9];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        for (var i = array.Length-1; i >= 0; i--)
        {
            var j =rand.Next(0,i + 1);
            (array[i], array[j]) = (array[j], array[i]);
        }
        return array;
    }
    
}