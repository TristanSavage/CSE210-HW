using System;
using System.Globalization;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {   
        House newHouse = new House();

        SmartLight light1 = new SmartLight("light1");
        SmartLight light2 = new SmartLight("light2");
        SmartLight light3 = new SmartLight("light3");
        SmartHeater heater1 = new SmartHeater("heater1");
        SmartHeater heater2 = new SmartHeater("heater2");
        SmartHeater heater3 = new SmartHeater("heater3");
        SmartTV TV1 = new SmartTV("TV1");
        SmartTV TV2 = new SmartTV("TV2");

        Room familyRoom = new Room("familyRoom");
        Room gameRoom = new Room("gameRoom");
        Room kitchen = new Room("kitchen");

        newHouse.AddToList(familyRoom);
        newHouse.AddToList(gameRoom);
        newHouse.AddToList(kitchen);

        familyRoom.AddToList(light1);
        familyRoom.AddToList(heater1);
        familyRoom.AddToList(TV1);

        gameRoom.AddToList(light2);
        gameRoom.AddToList(heater2);
        gameRoom.AddToList(TV2);

        kitchen.AddToList(light3);
        kitchen.AddToList(heater2);

        // light1.TurnON();
        // Thread.Sleep(2500);
        // Console.WriteLine(light1.CheckTime());

        familyRoom.TurnOnDevices();
        familyRoom.TurnOffLights();
        familyRoom.ReportStatus();
    }
}