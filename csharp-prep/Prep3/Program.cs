using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Try and guess my secret number!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int guess = 0;
        
        int i = 0;
        bool play = true;

        do
        {
            i += 1;

            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Higher!");
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower!");
            }

            else if (guess == number)
            {
                play = false;
                Console.WriteLine("NAILED IT!");
                Console.WriteLine($"Number of guesses: {i}");

                Console.WriteLine("Would you like to play again? (yes/no)");
                string response = Console.ReadLine();
                if (response == "yes")
                {
                    play = true;
                    number = randomGenerator.Next(1,100);
                    i = 0;
                }
            }

        } while (guess != number && play == true);
    }
}