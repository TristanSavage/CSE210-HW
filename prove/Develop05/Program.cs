using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        GoalManager goalManager = new GoalManager();

        string choice = "";
        while (choice != "6" && choice != "quit")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {goalManager.GetTotalPoints()} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
            Console.Write("Select a choice from the Menu above: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. CheckList Goal");
                    Console.WriteLine("  4. Negative Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    string goalChoice = Console.ReadLine();

                    switch (goalChoice)
                    {
                        case "1":
                            SimpleGoal newSimpleGoal = new SimpleGoal();
                            goalManager.AddToList(newSimpleGoal);
                        break;
                        
                        case "2":
                            EternalGoal newEternalGoal = new EternalGoal();
                            goalManager.AddToList(newEternalGoal);
                        break;

                        case "3":
                            CheckListGoal newCheckGoal = new CheckListGoal();
                            goalManager.AddToList(newCheckGoal);
                        break;

                        case "4":
                            NegativeGoal newNegativeGoal = new NegativeGoal();
                            goalManager.AddToList(newNegativeGoal);
                        break;

                        default:
                        Console.WriteLine("Invalid Response. Please try again.");
                        Thread.Sleep(2000);
                        break;
                    }

                break;
                
                case "2":
                    goalManager.DisplayAllGoals();

                break;
                
                case "3":
                    goalManager.SaveToFile();

                break;

                case "4":
                    goalManager.LoadFromFile();
                break;

                case "5":
                    goalManager.DisplayAllGoals();
                    goalManager.CompleteAGoal();

                break;

                case "6":
                break;
                
                default:
                    Console.WriteLine("Invalid Response. Please try again.");
                    Thread.Sleep(2000);
                break;
            }

        }


    }
}