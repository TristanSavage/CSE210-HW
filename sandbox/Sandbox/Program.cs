using System;

class Program
{
    static void Main(string[] args)
    {

        int x;
        x = 10;
        Console.WriteLine(x);

        float y = 5;
        Console.WriteLine(y);

        Console.Write("There will not be a newline after this.");

        Console.WriteLine("Hello World!");

        // Console.Write("What is your favorite color? ");
        // string color = Console.ReadLine();

        if (x > y)
            {
            Console.WriteLine("greater");
            }

        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");
        
    }
}