namespace section07;
/*
Create a simple C# program that demonstrates handling multiple types of exceptions. The program should:

Declare a method HandleMultipleExceptions which:
Takes a string  and an int as parameters, in that order.
Contains a local int[] variable with predefined elements, for example, int[] numbers = { 1, 2, 3 };.
Contains a try block where you:
Attempt to parse an integer from the string parameter that could throw a FormatException.
Access an element in the array by the integer parameter as an index that could throw an IndexOutOfRangeException.
Catch and handle both FormatException and IndexOutOfRangeException.
Print specific messages for each exception type.

Alert!
The result of execution should be:
If a FormatException occurs: "Invalid format."
If an IndexOutOfRangeException occurs: "Index out of range."
If no exception occurs: the accessed array element.
Example output for no exception: "2"
Example output for FormatException: "Invalid format."
Example output for IndexOutOfRangeException: "Index out of range."
*/
public class CodeExe18
{
    static void HandleMultipleExceptions(string inputstring, int index)
    {
        int[] numbers = {1,2,3};

        try
        {
            int parsedNumber = int.Parse(inputstring);
            Console.WriteLine(numbers[index]);
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Invalid format.");
        }
        catch (IndexOutOfRangeException)
        {
            System.Console.WriteLine("Index out of range");
        }
    }

    public static void Run()
    {
        HandleMultipleExceptions("100",1);
        HandleMultipleExceptions("abc",0);
        HandleMultipleExceptions("50",5);    
    }
}