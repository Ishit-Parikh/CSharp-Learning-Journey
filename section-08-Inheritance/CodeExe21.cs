namespace Section08;

/*
Create a C# program that demonstrates method overriding using the override and virtual keywords. The program should:

Declare a base class Animal with a virtual method MakeSound that prints "Animal makes a sound".
Declare a derived class Dog that overrides the MakeSound method to print "Dog barks".
Declare another derived class Cat that overrides the MakeSound method to print "Cat meows".
Create instances of Animal, Dog, and Cat, and call the MakeSound method on each instance to demonstrate method overriding.

Alert!
The result of execution for the default string should be:
"Animal makes a sound" "Dog barks" "Cat meows"

*/

public class Animal1
{
    public virtual void MakeSound()
    {
        System.Console.WriteLine("Animal makes a sound");
    }
}

public class Dog1: Animal1
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Dog Barks");
    }
}

public class Cat: Dog1
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Cat Meows");
    }
}

public class CodeExe21
{
    public  static void Run()
    {
        Animal1 animal1 = new Animal1();
        Dog1 dog1 = new Dog1();
        Cat cat = new Cat();

        animal1.MakeSound();
        dog1.MakeSound();
        cat.MakeSound();
    }
}