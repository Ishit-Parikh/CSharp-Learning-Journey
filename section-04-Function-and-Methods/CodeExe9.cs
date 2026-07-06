/*

#########################################

Create a simple C# program that calculates the average temperature from an array of temperatures. The program should:

Declare a method CalculateAverage that takes an array of doubles as a parameter.

Implement the method to calculate the average of the temperatures in the array.

Declare a method PrintAverage that takes an array of doubles as a parameter.

Implement the method to call CalculateAverage and print the result to the console.

#########################################

*/


using System;

namespace Section04;

public class CodeExe9
{

    static double[] temps = {23.5, 23.5, 23.5, 23.5, 23.5, 23.5, 23.5, 23.5, 23.5, 23.5};

    public static void Run()
    {
        PrintAverage(temps);
    }

    public static double CalculateAverage(double[] temperatures)
    {
        double tempAverage = 0;
        double tempSum = 0;
        
        foreach(double temp in temperatures)
        {
            tempSum += temp;
        }

        tempAverage = tempSum/ temperatures.Length;

        return tempAverage;
    }

    public static void PrintAverage(double[] temperatures)
    {
        System.Console.WriteLine($"The Average Temperature is :{CalculateAverage(temperatures)}");
    }
}