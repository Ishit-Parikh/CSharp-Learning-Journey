using System;
using System.Diagnostics.CodeAnalysis;

namespace Section03;

public class CodeExe8
{
    public static void Run()
    {
        int[][] my2Darray =
        {
            new int[] {1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9}
        };
        for(int i = 0; i < my2Darray.Length; i++)
        {
            int sum = 0;
            for(int j = 0; j < my2Darray[i].Length; j++)
            {
                sum += my2Darray[i][j];
            }
            Console.WriteLine(sum);
        }
    }
}