using System;
using static System.Math;

partial class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        SolarSystemManager SSM = new SolarSystemManager();

        string choice = "";
        while (choice != "6" && choice != "quit")
        {
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Generate Solar System (With Planets)");
            Console.WriteLine("    2. Generate Solar System (With Planets and Asteroids)");
            Console.WriteLine("    3. See Current Solar System State");
            Console.WriteLine("    4. Experiment w/ Current Solar System!");
            Console.WriteLine("    5. Clear Console");
            Console.WriteLine("    6. Quit");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SSM.ClearSystemManager();
                    PlanetsSolarSystem PlanetSolarSystem = new PlanetsSolarSystem(SSM);
                    break;
                
                case "2":
                    SSM.ClearSystemManager();
                    AsteroidSolarSystem AsteroidSolarSystem = new AsteroidSolarSystem(SSM);
                    break;

                case "3":
                    SSM.DisplayStatusALL("Current State");
                    Console.WriteLine();
                    Console.WriteLine("  -Press ENTER to continue-");
                    Console.ReadLine();
                    break;

                case "4":
                    string SubChoice = "";

                    while (SubChoice != "10")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Choose an Option:");
                        Console.WriteLine("    1. See Current Solar System State");
                        Console.WriteLine("    2. Elapse Earth Years");
                        Console.WriteLine("    3. Elapse Mercury Years");
                        Console.WriteLine("    4. Elapse Venus Years");
                        Console.WriteLine("    5. Elapse Mars Years");
                        Console.WriteLine("    6. Elapse Jupiter Years");
                        Console.WriteLine("    7. Elapse Saturn Years");
                        Console.WriteLine("    8. Elapse Uranus Years");
                        Console.WriteLine("    9. Elapse Neptune Years");
                        Console.WriteLine("    10. Return to Main Menu");

                        SubChoice = Console.ReadLine();
                        float YM = 0;

                        switch (SubChoice)
                        {
                            case "1":
                                SSM.DisplayStatusALL("Current State");
                                Console.WriteLine();
                                Console.WriteLine("  -Press ENTER to continue-");
                                Console.ReadLine();
                                break;
                            
                            case "2":
                                Console.WriteLine("How many Earth years are to be elapsed?");
                                YM = float.Parse(Console.ReadLine()); // Year Multiplier

                                SSM.DisplayStatus("Anterior Earth Position","Earth");
                                SSM.RunRK4(0,YM*1,0.001);
                                SSM.DisplayStatus("Posterior Earth Position","Earth");
                                Console.WriteLine("  -Press ENTER to continue-");
                                Console.ReadLine();
                                break;
                                
                            case "3":
                                Console.WriteLine("How many Mercury years are to be elapsed?");
                                YM = float.Parse(Console.ReadLine()); // Year Multiplier

                                SSM.DisplayStatus("Anterior Mercury Position","Mercury");
                                SSM.RunRK4(0,YM*0.2411,0.001);
                                SSM.DisplayStatus("Posterior Mercury Position","Mercury");
                                Console.WriteLine("  -Press ENTER to continue-");
                                Console.ReadLine();
                                break;

                            case "4":
                                Console.WriteLine("How many Venus years are to be elapsed?");
                                YM = float.Parse(Console.ReadLine()); // Year Multiplier

                                SSM.DisplayStatus("Anterior Venus Position","Venus");
                                SSM.RunRK4(0,YM*0.6164,0.001);
                                SSM.DisplayStatus("Posterior Venus Position","Venus");
                                Console.WriteLine("  -Press ENTER to continue-");
                                Console.ReadLine();
                                break;

                            case "5":
                                Console.WriteLine("How many Mars years are to be elapsed?");
                                YM = float.Parse(Console.ReadLine()); // Year Multiplier

                                SSM.DisplayStatus("Anterior Mars Position","Mars");
                                SSM.RunRK4(0,YM*1.8822,0.001);
                                SSM.DisplayStatus("Posterior Mars Position","Mars");
                                Console.WriteLine("  -Press ENTER to continue-");
                                Console.ReadLine();
                                break;

                            case "6":
                                Console.WriteLine("How many Jupiter years are to be elapsed?");
                                YM = float.Parse(Console.ReadLine()); // Year Multiplier

                                SSM.DisplayStatus("Anterior Jupiter Position","Jupiter");
                                SSM.RunRK4(0,YM*11.8712,0.001);
                                SSM.DisplayStatus("Posterior Jupiter Position","Jupiter");
                                Console.WriteLine("  -Press ENTER to continue-");
                                Console.ReadLine();
                                break;

                            case "7":
                                Console.WriteLine("How many Saturn years are to be elapsed?");
                                YM = float.Parse(Console.ReadLine()); // Year Multiplier

                                SSM.DisplayStatus("Anterior Saturn Position","Saturn");
                                SSM.RunRK4(0,YM*29.4685,0.001);
                                SSM.DisplayStatus("Posterior Saturn Position","Saturn");
                                Console.WriteLine("  -Press ENTER to continue-");
                                Console.ReadLine();
                                break;

                            case "8":
                                Console.WriteLine("How many Uranus years are to be elapsed?");
                                YM = float.Parse(Console.ReadLine()); // Year Multiplier

                                SSM.DisplayStatus("Anterior Uranus Position","Uranus");
                                SSM.RunRK4(0,YM*84.0740,0.001);
                                SSM.DisplayStatus("Posterior Uranus Position","Uranus");
                                Console.WriteLine("  -Press ENTER to continue-");
                                Console.ReadLine();
                                break;

                            case "9":
                                Console.WriteLine("How many Neptune years are to be elapsed?");
                                YM = float.Parse(Console.ReadLine()); // Year Multiplier

                                SSM.DisplayStatus("Anterior Neptune Position","Neptune");
                                SSM.RunRK4(0,YM*164.9041,0.001);
                                SSM.DisplayStatus("Posterior Neptune Position","Neptune");
                                Console.WriteLine("  -Press ENTER to continue-");
                                Console.ReadLine();
                                break;

                            case "10":
                                break;

                            default:
                                Console.WriteLine("Invalid Response. Please try again.");
                                Thread.Sleep(2000);
                            break;
                        }
                    }
                    break;

                case "5":
                    Console.Clear();
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