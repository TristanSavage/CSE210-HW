using System;
using static System.Math;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        double pi = Math.PI;
        double reducedSunMass = 4*pi*pi;
        double SunMass = 2e30;
        double SunMassRatio = reducedSunMass/SunMass;

        SolarSystemManager SSM = new SolarSystemManager();

        Star Sun = new Star("Sun", reducedSunMass,true);
        SSM.AddBody(Sun);

        Planet Earth = new Planet("Earth", 6e24*SunMassRatio, 1,0,0,2*pi);
        SSM.AddBody(Earth);

        // Earth.PrintLists();

        SSM.RunRK4();
        Earth.PrintLists();
        // Sun.PrintLists();

    }
}