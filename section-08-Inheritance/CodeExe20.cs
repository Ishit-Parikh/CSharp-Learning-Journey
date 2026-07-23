namespace Section08;

/*
Create a simple C# program that demonstrates constructor inheritance. Define a base class Person with a constructor that takes a name and prints a message. Then, create a derived class Employee that calls the base class constructor and adds additional functionality. Print the messages to the console.

Alert!
The result of execution should be:
"Person constructor: John Doe" "Employee constructor: John Doe, ID: 123"
*/

public class Person
{
    public string Name {get; private set;}

    public Person (string name)
    {
        Name = name;
        System.Console.WriteLine($"Person constructor: {Name}");
    }
}

public class Employee : Person
{
    public int ID {get; private set;}

    public Employee(string name, int id) : base(name)
    {
        ID = id;
        System.Console.WriteLine($"Employee constructor:{name} {ID}");
    }
}

public class CodeExe20
{
    public static void Run()
    {
        Employee employee = new Employee("John Doe", 123);
    }
}