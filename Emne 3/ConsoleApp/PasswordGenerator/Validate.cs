namespace PasswordGenerator;

public static class Validate
{
    public static bool IsValid(string?[] args)
    {
        if (args.Length < 2 || !int.TryParse(args[0], out var number) || number < 6) 
            return false;

        var text = args[1];
        if (string.IsNullOrEmpty(text)) 
            return false;

        const string requirements = "lLsd";

        foreach (var c in text)
        {
            if (Char.IsDigit(c) || !requirements.Contains(c)) 
                return false;
        }

        return true;
    }

    public static string CreatePattern(string?[] args)
    {
        int passwordLength = int.Parse(args[0] ?? string.Empty);
        string? userPattern = args[1];
        string pattern = "";
        while (pattern.Length < passwordLength)
        {
            pattern += userPattern;
        }

        while (pattern.Length > passwordLength)
        {
            pattern = pattern.Substring(0, passwordLength);
        }

        while (pattern.Length < passwordLength)
        {
            pattern += "l";
        }
        return pattern;
    }
}