class Activities
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructors

    // Behaviors
    protected void DisplayDescription()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        this.SetDuration();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        this.AnimateSpinner(3);
    }

    protected void SetDuration()
    {
        Console.Write("How long, in seconds, would you like this session to last? > ");

        _duration = int.Parse(Console.ReadLine());
    }

    protected void ActivityCompletionMessage()
    {
        Console.WriteLine("Well Done!!");
        this.AnimateSpinner(3);
        
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        this.AnimateSpinner(5);
    }

    protected void AnimateSpinner(int count)
    {
        int sleepTime = 75;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(count);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            // Line 1
            Console.WriteLine(" _   \n|    \n     ");

            // int x = Console.CursorLeft;  // starting column on first line
            int x = 0;
            int y = Console.CursorTop - 3;  // starting row (3 lines back)

            // Line 2
            Thread.Sleep(sleepTime);
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" __  \n     \n     ");

            // Line 3
            Thread.Sleep(sleepTime);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("  __ \n     \n     ");

            // Line 4
            Thread.Sleep(sleepTime);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("    _\n    |\n     ");

            // Line 5
            Thread.Sleep(sleepTime);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("     \n    |\n    |");
            
            // Line 6
            Thread.Sleep(sleepTime);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("     \n     \n   _|");

            // Line 7
            Thread.Sleep(sleepTime);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("     \n     \n  __ ");

            // Line 8
            Thread.Sleep(sleepTime);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("     \n     \n __  ");

            // Line 9
            Thread.Sleep(sleepTime);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("     \n     \n|_   ");

            // Line 10
            Thread.Sleep(sleepTime);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("     \n|    \n|    ");

            Thread.Sleep(sleepTime);
            Console.SetCursorPosition(x, y);

            currentTime = DateTime.Now;
        }

        // Line Clear
        Console.WriteLine("     \n     \n     ");
    }

    protected void AnimateCountDown(int count)
    {
        string countDown = "";
        List<char> chars = new List<char>();
        for (int i = 1; i <= count; i++)
        {
            
            chars.Add('-');
            
            Console.CursorLeft = 0;
            Thread.Sleep(50);
            countDown = String.Concat(chars);

            for (i = 0; i < chars.Count; i++)
            {
                Console.Write(" ");
            }
            
            Console.CursorLeft = 0;
            Console.Write(" ");
            Console.Write($"{countDown}");
        }

        for (int i = 0; i <= count; i++)
        {
            Console.CursorLeft = count - i + 1;
            Thread.Sleep(1000);
            Console.Write($"_");
        }
    }
}