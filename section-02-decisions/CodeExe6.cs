using System;
namespace Section02;

public class CodeExe6
{
    public static void Run()
    {
        System.Console.WriteLine("Enter a number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Enter a second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Enter one of the following operations to perform (+, -, *, /):");
        string operation = Console.ReadLine();
        double result = 0;
        switch (operation)
        {
            case "+":
                result = number1 + number2;
                System.Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, result);
                break;
            case "-":
                result = number1 - number2;
                System.Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, result);
                break;
            case "*":
                result = number1 * number2;
                System.Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, result);
                break;
            case "/":
                if( number2 == 0){
                    System.Console.WriteLine("For Division, the denominator can't be 0");
                }
                else{
                    result = number1 / number2;
                    System.Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, result);
                }
                break;
            default:
                System.Console.WriteLine("Please enter a valid operation.");
                break;
        }
    }
}