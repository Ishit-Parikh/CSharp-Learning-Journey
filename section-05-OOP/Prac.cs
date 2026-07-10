using System.Runtime.Intrinsics.Arm;

namespace Section05;

public class Prac
{

    private string programmingLanguage;

    public string ProgrammingLanguage {
        get => programmingLanguage;
        
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You have entered nothing.\nGo back to learning Scratch");
                programmingLanguage = "Scratch";
            }
            else
            {
                programmingLanguage = value;
            }
        }
    }

    public Prac()
    {
        System.Console.WriteLine("You have started learning a new Programming Language.");
    }

    public static void main()
    {
        Prac prac = new Prac();
        System.Console.Write("Enter which programming language you want to learn now: ");
        prac.ProgrammingLanguage = Console.ReadLine();

        System.Console.WriteLine($"Great, from today you want to learn {prac.ProgrammingLanguage}.");
    }
}