using System.Globalization;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace Section06;

public class Listdemo
{
    public static void Run()
    {
        //create new empty List.
        List<int> ankio = new List<int>();

        //add new items in the list
        ankio.Add(1);
        ankio.Add(2);
        ankio.Add(3);
    
        //read those items or specific items
        //reading a specific item at index
        System.Console.WriteLine(ankio[2]);

        //reading all items 
        foreach(int nums in ankio)
        {
            System.Console.WriteLine(nums);
        }
        
        
        //remove items from a list
        bool isRemoved = ankio.Remove(3);
        if (isRemoved)
        {
            System.Console.WriteLine("Element 3 has been removed");
        }
        
        //create a new list with items when initialized
        List<string> strings = ["This ","List ", "has ","it's ", "elements ","Pre-initialised."];
        foreach(string words in strings)
        {
            System.Console.Write(words);
        }
        System.Console.WriteLine();
    }
}