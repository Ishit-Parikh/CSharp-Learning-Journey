using System;

namespace Section03;

public class CodeExe7
{
    public static void Run()
    {
        int[] myInts = new int[5];
        myInts = new int[] {1, 2, 3, 4, 5};
        foreach(int ints in myInts)
        {
            System.Console.WriteLine(ints);
        }
    }
}