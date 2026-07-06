using System;

namespace Section03;
public class RocketLanding
{
    public static void Run()
    {
        string RocketLanding = "   /\\\n  /  \\\n /____\\\n   ||\n   ||\n   VV";
        for(int i = 10; i >= 0; i--)
        {
            Console.Clear();
            System.Console.WriteLine($"Counter: {i}");
            System.Console.WriteLine(RocketLanding);
            RocketLanding = "\r\n" + RocketLanding;
            Thread.Sleep(1000);
        }
        System.Console.WriteLine("Rocket has landed successfully.");
    }
}