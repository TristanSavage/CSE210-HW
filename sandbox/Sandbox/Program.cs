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

        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");

        if (x > y)
            {
            Console.WriteLine("greater than");
            }
        
        if (x > y)
            {
                Console.WriteLine("greater than");
            }
            else
            {
                Console.WriteLine("less than");
            }

        if (x > y)
            {
                Console.WriteLine("greater than y");
            }
            else if (x > z)
            {
                Console.WriteLine("greater than z");
            }
            else
            {
                Console.WriteLine("less than both");
            }
        

    }
}