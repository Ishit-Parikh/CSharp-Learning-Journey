namespace Section06;

/*

INSTRUCTIONS:
Your task is to create a C# program that:
Declares a List of integers inside the PrintNumbers method.
Initializes the list with the values 1, 2, and 3.
Uses a foreach loop to print each number followed by a space.

Important Notes:
To avoid compatibility issues, use this syntax:

List<int> myNumbers = new List<int> { 1, 2, 3 };
Do not use List<int> myNumbers = [1, 2, 3];, as it may not work in all environments.

The expected output is:
1 2 3 
(Each number followed by a space, no newline at the end).

*/

public class CodeExe13
{
    public static void Run()
    {
        List<int> nums = new List<int> {1,2,3};
        foreach(var num in nums)
        {
            System.Console.Write($"{num} ");
        }
    }
}