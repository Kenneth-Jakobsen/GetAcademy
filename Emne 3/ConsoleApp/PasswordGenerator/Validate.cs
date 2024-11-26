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
}