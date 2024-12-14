using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // List<float> list = new List<float>{1,2,3,4,5};

        // foreach (float number in list)
        // {
        //     number *= 2;
        //     Console.WriteLine(number);
        // }

        double[] array1 = new double[3]; // 1D array
        array1[0] = 1;
        array1[1] = 2;
        array1[2] = 3;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(array1[i]);
            array1[i] *= 2;
            Console.WriteLine(array1[i]);
            Console.WriteLine();
        }

        // Console.WriteLine(array1[0] + array1[1]*array1[2]);
        // Console.WriteLine(array1[1]);

        // array1[1] /= 3;
        // Console.WriteLine(array1[1]);

        // Console.WriteLine();

        // int[,] array2 = new int[3, 3]; // 2D array
        // array2[0, 0] = 1;
        // array2[0, 1] = 10;
        // array2[0, 2] = 100;
        // array2[1, 2] = 2;
        // array2[2, 2] = 3;

        // Console.WriteLine(array2[0,0] + array2[0,1]*array2[0,2]);


    //     Console.WriteLine("What is your grade-percentage? ");
    //     int grade = int.Parse(Console.ReadLine());

    //     string letter = "S";

    //     if (grade >= 90)
    //     {
    //         letter = "n A";
    //     }

    //     else if (grade >= 80)
    //     {
    //         letter = " B";
    //     }

    //     else if (grade >= 70)
    //     {
    //         letter = " C";
    //     }

    //     else if (grade >= 60)
    //     {
    //         letter = " D";
    //     }

    //     else if (grade < 60)
    //     {
    //         letter = "n F";
    //     }

    //     else
    //     {
    //         Console.WriteLine("Error somewhere...");
    //     }

    //     string sign = "";

    //     if (grade%10 >= 7 && grade < 90 && grade >=60)
    //     {
    //         sign = "+";
    //     }

    //     else if (grade%10 < 3 && grade >=60)
    //     {
    //         sign = "-";
    //     }

    //     Console.WriteLine($"You got a{letter}{sign}");

    //     if (grade >= 70)
    //     {
    //         Console.WriteLine("Well done! Thou hast passed thine class!");
    //     }

    //     else
    //     {
    //         Console.WriteLine("Thou faileth thine class...");
    //     }
    }
}