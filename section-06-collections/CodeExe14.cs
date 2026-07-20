namespace Section06;

public class CodeExe14
{   
    public static void Run()
    {
        List<int> myNumbers = new List<int> { 1, 6, 3 };
        bool isHigher = myNumbers.Any(myNumbers => myNumbers > 5);
        Console.WriteLine(isHigher);
    }
}