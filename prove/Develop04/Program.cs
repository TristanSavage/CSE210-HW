using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing newBreathingActivity = new Breathing();
        Reflection newReflectionActivity = new Reflection();
        Listing newListingActivity = new Listing();

        string choice = "";
        while (choice != "4" && choice != "quit")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start Breathing Activity");
            Console.WriteLine("    2. Start Reflection Activity");
            Console.WriteLine("    3. Start Listing Activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the Menu above: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    newBreathingActivity.RunBreathingActivity();
                break;
                
                case "2":
                    newReflectionActivity.RunReflectionActivity();
                break;
                
                case "3":
                    newListingActivity.RunListingActivity();
                break;

                case "4":
                break;
                
                default:
                    Console.WriteLine("Invalid Response. Please try again.");
                    Thread.Sleep(2000);
                break;
            }

        }
    }
}