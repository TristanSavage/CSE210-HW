using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = 1;

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

        } while (number != 0);

        float sum = 0;
        float average = 0;
        float maximum = 0;

        foreach (float n in numbers)
        {
            sum += n;
            
            if (n > maximum)
            {
                maximum = n;
            }
        }
        average = sum/numbers.Count;
        Console.WriteLine(numbers.Count);

        Console.WriteLine($"The Sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {maximum}");

    }
}