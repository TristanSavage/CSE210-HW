using System;

class Program
{
    static void Main(string[] args)
    {
            static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the Program!");
            }

            static string PromptUserName()
            {
                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();
                
                return name;
            }

            static int PromptUserNumber()
            {
                Console.Write("Please enter your fravorite number: ");
                int number = int.Parse(Console.ReadLine());

                return number;
            }

            static int SquareNumber(int number)
            {
                return number*number;
            }

            static void DisplayResults(string name, int number)
            {
                Console.WriteLine($"{name}, the square of your favorite number is {number}.");
            }

            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            number = SquareNumber(number);
            DisplayResults(name,number);
    }
}