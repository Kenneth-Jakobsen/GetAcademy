namespace PasswordGenerator;

public static class GeneratePassword
{
    static readonly Random Random = new Random();
    public static string Generate(string? pattern)
    {
        string password = "";
        foreach (var c in pattern)
        {
            switch (c)
            {
                case 'L':
                    password += WriteRandomUpperCaseLetter();
                    break;
                case 'l':
                    password += WriteRandomLowerCaseLetter();
                    break;
                case 'd':
                    password += WriteRandomDigit();
                    break;
                case 's':
                    password += WriteRandomSpecialCharacter();
                    break;
            }
        }

        return password;
    }

    private static char WriteRandomUpperCaseLetter()
    {
        return GetRandomLetter('A', 'Z');
    }

    private static char WriteRandomLowerCaseLetter()
    {
        return GetRandomLetter('a', 'z');
    }

    private static int WriteRandomDigit()
    {
        return Random.Next(0, 10);
    }

    private static char WriteRandomSpecialCharacter()
    {
        char[] specialChars = [ '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_' ];
        var random = Random.Next(0, specialChars.Length);
        return specialChars[random];
    }
    
    static char GetRandomLetter(char min, char max)
    {
        return (char)Random.Next(min, max);
    }

}