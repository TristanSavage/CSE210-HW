using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade-percentage? ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "S";

        if (grade >= 90)
        {
            letter = "n A";
        }

        else if (grade >= 80)
        {
            letter = " B";
        }

        else if (grade >= 70)
        {
            letter = " C";
        }

        else if (grade >= 60)
        {
            letter = " D";
        }

        else if (grade < 60)
        {
            letter = "n F";
        }

        else
        {
            Console.WriteLine("Error somewhere...");
        }

        string sign = "";

        if (grade%10 >= 7 && grade < 90 && grade >=60)
        {
            sign = "+";
        }

        else if (grade%10 < 3 && grade >=60)
        {
            sign = "-";
        }

        Console.WriteLine($"You got a{letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Well done! Thou hast passed thine class!");
        }

        else
        {
            Console.WriteLine("Thou faileth thine class...");
        }
    }
}