namespace ConsoleApp;

public static class Assignment315A
{
    private static Random random = new Random(); 

    public static int GetRandomNumber()
    {
        return random.Next(1, 101);
    }

    public static void GuessingGame()
    {
        int randomNumber = GetRandomNumber();
        bool isCorrect = false;

        Console.WriteLine("Guess a number between 1 and 100:");

        while (!isCorrect)
        {
            string? input = Console.ReadLine();
            int guessedNumber = Convert.ToInt32(input);
            {
                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("Your input is correct! Congratulations!");
                    isCorrect = true;
                }
                else if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }
        }
    }
}