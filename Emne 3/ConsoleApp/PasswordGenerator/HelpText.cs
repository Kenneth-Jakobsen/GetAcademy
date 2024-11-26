namespace PasswordGenerator;

public static class HelpText
{
    public static void ShowHelpText()
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