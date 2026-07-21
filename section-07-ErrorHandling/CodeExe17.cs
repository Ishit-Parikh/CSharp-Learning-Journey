namespace section07;

/*
Create a simple C# program that demonstrates the use of the finally block. 

The program should:
Declare a method PrintWithFinally which contains a try block that writes "Trying..." to the console.
Add a finally block that writes "Finally executed." to the console.
Ensure the finally block executes even if the try block does not throw an exception.

Alert!
The result of execution for the default string should be:
"Trying..." "Finally executed."
*/

public class CodeExe17
{
    public static void Run()
    {
        try
        {
            System.Console.WriteLine("Trying ...");
        }
        finally
        {
            System.Console.WriteLine("Finally executed.");
        }
    }
}