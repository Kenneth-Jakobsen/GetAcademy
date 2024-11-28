namespace PasswordGenerator
{
 static class Program
    {
       private static void Main()
       {
            HelpText.ShowHelpText();
            Console.WriteLine("Enter your password requirements: ");
            var arguments = Console.ReadLine()?.Split(' ');
            if (!Validate.IsValid(arguments))
            {
                HelpText.ShowHelpText();
                return;
            }
            string? pattern = Validate.CreatePattern(arguments);
            string password =  GeneratePassword.Generate(pattern);
            Console.WriteLine(password);
       }
    }
}
