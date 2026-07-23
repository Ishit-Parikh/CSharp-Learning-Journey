using Microsoft.VisualBasic;

namespace Section08;

/*
Create a simple C# program that demonstrates inheritance. Define a base class Animal with a MakeSound method. Then, create a derived class Dog that overrides the MakeSound method. Use the base keyword to call the base class method within the derived class method. Print the sounds to the console.

Alert!
The result of execution should be:
"Animal sound" "Dog barks"
*/

public class Animal
{
    public virtual void MakeSound()
    {
        System.Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        System.Console.WriteLine("Dog barks");
    }
}

public class CodeExe19
{
    public static void Run()
    {
        Dog dog = new Dog();
        dog.MakeSound();
    }
}