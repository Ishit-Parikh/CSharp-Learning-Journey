namespace Section06;


/*
Create a simple C# program that declares a dictionary with string keys and values of type List<int>, initializes it with one key-value pair, and prints the values of the list for the given key to the console.

Alert!
The result of execution for the default string should be:
"1 2 3 " (Plus a space after the "3")
*/

public class CodeExe15
{
    public static void Run()
    {
        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
        List<int> list = [1,2,3];
        dict.Add("Key", list);

        foreach(var item in dict)
        {
            foreach(var ints in item.Value)
            {
                System.Console.Write($"{ints} ");
            }
        }
    }
}