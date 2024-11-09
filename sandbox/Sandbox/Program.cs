using System;
using System.Globalization;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        int sleepTime = 40;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(2);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
        // Line 1
        Console.WriteLine(" _   \n|    \n     ");

        int x = Console.CursorLeft;  // starting column on first line
        int y = Console.CursorTop - 3;  // starting row (3 lines back)


        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(x, y);
        // Line 2
        Console.WriteLine(" __  \n     \n     ");

        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(x, y);
        // Line 3
        Console.WriteLine("  __ \n     \n     ");

        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(x, y);
        // Line 4
        Console.WriteLine("    _\n    |\n     ");

        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(x, y);
        // Line 5
        Console.WriteLine("     \n    |\n    |");
        
        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(x, y);
        // Line 6
        Console.WriteLine("     \n     \n   _|");

        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(x, y);
        // Line 7
        Console.WriteLine("     \n     \n  __ ");

        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(x, y);
        // Line 8
        Console.WriteLine("     \n     \n __  ");

        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(x, y);
        // Line 9
        Console.WriteLine("     \n     \n|_   ");

        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(x, y);
        // Line 10
        Console.WriteLine("     \n|    \n|    ");

        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(x, y);

        currentTime = DateTime.Now;
        }
    }
}