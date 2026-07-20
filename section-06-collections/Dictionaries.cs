using System.Collections;

namespace Section06;

public class Dictionaries
{
    public static void Run()
    {

        //creating a empty dictionary
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        
        //adding elements in that list
        dictionary.Add(1, "Ishit");
        dictionary.Add(2, "Parikh");
        dictionary.Add(3, "Danis");

        //accessing items based on the key.
        //System.Console.WriteLine($"Hi my name is {dictionary[1]}");

        //accessing the entire dictionary
        foreach(KeyValuePair<int, string> dict in dictionary)
        {
            System.Console.WriteLine($"Name is {dict.Value} with ID {dict.Key}");
        }
    }
}