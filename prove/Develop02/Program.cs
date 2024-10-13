using System;
using System.Security;
using System.Collections.Generic;
using System.IO;


class Entry
{

    // Attributes
    public string _date = "";

    public string _prompt = "";

    public string _response = "";

    public List<string> promptsList = new List<string>();

    

    // Behaviors

    public string get_date()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }

    public string GeneratePrompt()
    {

        promptsList.Clear();

        promptsList.Add("What made you smile today, and why did it brighten your mood?");
        promptsList.Add("Describe a small victory you experienced today, no matter how minor.");
        promptsList.Add("What is one thing you learned today that inspired you?");
        promptsList.Add("Who did you connect with today, and what positive energy did that bring?");
        promptsList.Add("What was a moment of gratitude you felt today, and what sparked it?");
        promptsList.Add("Reflect on a challenge you faced today. How did you overcome it?");
        promptsList.Add("What was the most beautiful thing you saw today?");
        promptsList.Add("How did you practice self-care today, and how did it make you feel?");
        promptsList.Add("What is something that surprised you today, and how did it affect your perspective?");
        promptsList.Add("Describe a moment of laughter or joy you experienced today.");
        promptsList.Add("What intention did you set for today, and how did it influence your actions?");
        promptsList.Add("What are three things you are grateful for that happened today?");
        promptsList.Add("How did you spread kindness today, either to yourself or to someone else?");
        promptsList.Add("Reflect on a positive conversation you had today. What made it special?");
        promptsList.Add("What inspired you today, whether it was a person, a quote, or an event?");
        promptsList.Add("How did you express your creativity today, and how did it feel?");
        promptsList.Add("What is one thing you did today that brought you peace or calm?");
        promptsList.Add("What is a goal you worked toward today, and what progress did you make?");
        promptsList.Add("Describe a moment today when you felt truly present and connected to the moment.");
        promptsList.Add("What are your hopes or goals for tomorrow based on how today went?");

        Random rng = new Random();

        int rand = rng.Next(promptsList.Count);
        Console.WriteLine(promptsList[rand]);
        
        return promptsList[rand];

    }

    public string ReceiveResponse()
    {
        Console.Write(" > ");
        string input = Console.ReadLine();

        return input;
    }

}

class Journal
{
    // Variables
    public List<Entry> _entries = new List<Entry>();


    // Functions
    public void AddEntry()
    {

        Entry newEntry = new Entry();
        newEntry._date = newEntry.get_date();

        Console.WriteLine("");
        newEntry._prompt = newEntry.GeneratePrompt();
        newEntry._response = newEntry.ReceiveResponse();
        _entries.Add(newEntry);

        Console.WriteLine(" Response Received!");

    }

    public void DisplayJournalEntries()
    {
        int i = 1;
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("");
            Console.WriteLine($"Entry {i}");
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            i += 1;
        }

        Console.WriteLine("");

    }

    public void LoadFromFile()
    {
        Console.WriteLine("");
        Console.Write("File Name: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            string entryDate = parts[0];
            string entryPrompt = parts[1];
            string entryResponse = parts[2];

            Entry newEntry = new Entry();

            newEntry._date = entryDate;
            newEntry._prompt = entryPrompt;
            newEntry._response = entryResponse;
            _entries.Add(newEntry);

        }

        Console.WriteLine("File load --> Successful!");
        
    }

    public void SaveToFile()
    {
        Console.WriteLine("");
        Console.Write("File Name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            outputFile.WriteLine($"Date: {entry._date}~Prompt: {entry._prompt}~Response: {entry._response}");
        }

        Console.WriteLine("File Save --> Successful!");
    
    }
}

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