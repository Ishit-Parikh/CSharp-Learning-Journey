using System.Collections;

namespace Section06;


/*
public class Emp
{
    public string? Name {get; set;}
    public int? Age {get; set;}
    public int? Salary {get; set;}

    public Emp(string name, int age, int salary)
    {
        this.Name = name;
        this.Age = age;
        this.Salary = salary;
    }
}
*/

public class Dictionaries
{
    public static void Run()
    {
        /*
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

        Dictionary<int, Emp> emp = new Dictionary<int, Emp>();
        emp.Add(1, new Emp("Ishit", 20, 200000));
        emp.Add(2, new Emp("Parikh", 21, 300000));

        foreach(var item in emp)
        {
            System.Console.WriteLine($"ID: {item.Key}, Name: {item.Value.Name}, Age: {item.Value.Age}, Salary: {item.Value.Salary}");
        }
        */

        //New way to declare Dictionary
        var Codes = new Dictionary<string, string>
        {
            ["No"] = "Man",
        };
        Codes.Add("Ishit", "Parikh");


    }
}