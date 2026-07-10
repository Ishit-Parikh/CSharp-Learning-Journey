namespace Section05;

public class Prac
{

    private string programmingLanguage;

    public Prac(string _programmingLanguage)
    {
        programmingLanguage = _programmingLanguage;
        System.Console.WriteLine($"I am currently practicing {programmingLanguage}");
    }

    public static void Main()
    {
        Prac prac = new Prac("C#");
        Prac prac1 = new Prac("Java");
    }
}