namespace PasswordGenerator
{ 
    class Program
    {
       private static void Main(string[] args)
        {
            var smallLetter = 0;
            var capitalLetter = 0;
            var specialChars = 0;
            var number = 0;
            if (!IsValid(args))
            {
                PasswordGenerator();
            }
            else
            {
                foreach (var c in args[1])
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
                              $"and be {args[0]} characters long");
            }
        }

        private static bool IsValid(string[] args)
        {
            var number = int.Parse(args[0]);
            var requirements = args[1];
            if (number < 6 || requirements==" ") return false;
            foreach (var c in requirements)
            {
                if (Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }


        static void PasswordGenerator()
        {
            ShowHelpText();
        }

        static void ShowHelpText()
        {
            Console.WriteLine("PasswordGenerator  " +
                              "\nOptions:\n- l = liten bokstav\n- " +
                              "L = stor bokstav\n- " +
                              "d = siffer\n- " +
                              "s = spesialtegn (!\"#\u00a4%&/(){}[]\n-" +
                              "lengde skal være min 6 tegn\n" +
                              "Eksempel: PasswordGenerator 14 lLssdd\n" +
                              "    betyr\n " +
                              "    Min. 1 liten bokstav\n    " +
                              "    Min. 1 1 stor bokstav\n   " +
                              "    Min. 2 spesialtegn\n     " +
                              "    Min. 2 sifre\n   " +
                              "    Lengde på passordet skal være 14 tegn ");
        }

    }
}

