namespace CodeAlong;

class Program
{
    static void Main(string[] args)
    {
        var program = new textAnalyze("Den lille katten sov søtt på den gamle, slitte sofaen!!.");
        program.analyzeText();
    }
}