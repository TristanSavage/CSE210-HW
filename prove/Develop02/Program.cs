using System;
using System.Security;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {

        Journal newJournal = new Journal();

        string command = "";

        while (command != "7")
        {
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine(" 1. Write New Entry");
        Console.WriteLine(" 2. Display All Entries");
        Console.WriteLine(" 3. Load Entry File");
        Console.WriteLine(" 4. Save Entries to File");
        Console.WriteLine(" 5. Edit Entry");
        Console.WriteLine(" 6. Delete Entry");
        Console.WriteLine(" 7. Quit");
        Console.Write("What would you like to do? ");
        command = Console.ReadLine();
        
        switch (command)
        {
            case "1":
                Console.WriteLine("Command: Write");
                newJournal.AddEntry();
            break;

            case "2":
                Console.WriteLine("Command: Display");
                newJournal.DisplayJournalEntries();
            break;

            case "3":
                Console.WriteLine("Command: Load");
                newJournal.LoadFromFile();
            break;

            case "4":
                Console.WriteLine("Command: Save");
                newJournal.SaveToFile();
            break;



            case "5":
                Console.WriteLine("Command: Edit");
                newJournal.DisplayJournalEntries();
                Console.Write("Please choose which entry you would like to edit (Example: 1):");
                int editChoice = int.Parse(Console.ReadLine());
                
                Console.WriteLine(newJournal._entries[editChoice-1]._prompt);

                Console.WriteLine("Please enter a new response to replace the old one!");
                Console.Write(" > ");
                newJournal._entries[editChoice-1]._response = Console.ReadLine();
            break;

            case "6":
                Console.WriteLine("Command: Delete");
                newJournal.DisplayJournalEntries();
                Console.Write("Please choose which entry you would like to delete (Example: 1):");
                int deleteChoice = int.Parse(Console.ReadLine());
                
                newJournal._entries.RemoveAt(deleteChoice-1);
            break;
            

            case "7":
                Console.WriteLine("Command: Quit");
            break;

            default:
                Console.WriteLine("Invalid Response. Please try again.");
            break;
        }
        
        }
        
    }

    
}