class Reflection : PonderActivities
{
    // Attributes
    private List<string> _ponderQuestionList = new List<string>();
    private List<string> _unusedPonderQs = new List<string>();
    // Constructors
    public Reflection()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        _ponderQuestionList.Add("How did you feel after completing this experience?");
        _ponderQuestionList.Add("In your opinion, what is the most signficant aspect of this experience?");
        _ponderQuestionList.Add("What does this experience teach you about your own strength or resilience?");
        _ponderQuestionList.Add("Consider upon what the fundamental source of your strength may have been.");
        _ponderQuestionList.Add("How would you have felt if you hadn't made the choice that you did?");

        _promptList.Add("Think of a time when you faced a signficant setback or failure.");
        _promptList.Add("Think of time when you felt greatly out of your comfort zone.");
        _promptList.Add("Think of a time when you were met with unexpected adversity or obstacles.");
        _promptList.Add("Think of a time when you had to put aside your own comfort to support someone else.");
        _promptList.Add("Think of a time when you had to make a tough decision that others disagreed with or didn't understand.");

        _unusedPonderQs.AddRange(_ponderQuestionList);
        _unusedPrompts.AddRange(_promptList);
    }

    // Behaviors
    public void RunReflectionActivity()
    {
        this.DisplayDescription();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        string prompt = ChoosePrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Thread.Sleep(2000);

        Console.WriteLine("Activity will begin shortly!");
        this.AnimateCountDown(5);

        Console.Clear();
        Console.WriteLine("Go!");
        Console.WriteLine();
        Thread.Sleep(1000);

        int seconds = 10;
        for (int i = 0; i < _duration; i += seconds)
        {
            string ponderQ = ChoosePonderQuestion();
            Console.WriteLine($"> {ponderQ}");
            AnimateSpinner(seconds);
        }

        this.ActivityCompletionMessage();
    }

    private string ChoosePonderQuestion()
    {
        Random random = new Random();
        int index = random.Next(_unusedPonderQs.Count);
        string ponderQuestion = _unusedPonderQs[index];
        _unusedPonderQs.RemoveAt(index);

        if (_unusedPonderQs.Count == 0)
        {
            _unusedPonderQs.AddRange(_ponderQuestionList);
        }

        return ponderQuestion;
    }
}