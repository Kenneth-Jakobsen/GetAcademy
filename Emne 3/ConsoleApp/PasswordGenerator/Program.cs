namespace PasswordGenerator
{
 static class Program
    {
       private static void Main()
       {
            HelpText.ShowHelpText();
            Console.WriteLine("Enter your password requirements: ");
            var arguments = Console.ReadLine()?.Split(' ');
            var smallLetter = 0;
            var capitalLetter = 0;
            var specialChars = 0;
            var number = 0;
            if (!Validate.IsValid(arguments))
            {
                HelpText.ShowHelpText();
                return;
            }
            foreach (var c in arguments[1])
            {
                switch (c)
                {
                    case 'L':
                        capitalLetter++;
                        break;
                    case 'l':
                        smallLetter++;
                        break;
                    case 'd':
                        number++;
                        break;
                    case 's':
                        specialChars++;
                        break;
                }
            }
            Console.Write($"I want my password to have {smallLetter} small letters, " +
                          $"{capitalLetter} capital letters, " +
                          $"{number} numbers " +
                          $"and {specialChars} special characters " +
                          $"and be {arguments[0]} characters long");
       }
       
    }
}

