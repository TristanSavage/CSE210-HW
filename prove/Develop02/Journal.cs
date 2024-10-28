



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