using System.Security.Cryptography;

namespace section07;

public class ErrorHandling
{
    public static void Run()
    {
        string? input = null;
        System.Console.Write("Enter a number between 1 to 120: ");
        input = Console.ReadLine();
        int intInput = 0;
        if(! int.TryParse(input, out intInput))
        {
            throw new Exception("Please enter a valid input");
        }
        if(intInput < 0 || intInput > 120)
        {
            throw new Exception("I SAID BEWTEEN 1 & 120!");
        }
    }
}