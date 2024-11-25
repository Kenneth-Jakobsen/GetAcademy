namespace ConsoleApp
{
    internal class MyConsole
    {
       public static string Ask(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

       public static int AskForInt(string question)
        {
            var answerStr = Ask(question);
            return Convert.ToInt32(answerStr);
        }
    }
}
