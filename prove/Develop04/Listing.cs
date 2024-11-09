class Listing : PonderActivities
{
    // Attributes

    // Constructors
    public Listing()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _promptList.Add("When have you felt the Holy Ghost this month?");
        _promptList.Add("Ask yourself: 'Who can I share a Book of Mormon verse with this week?' - Who does the spirit bring to your mind right now?");
        _promptList.Add("What did you learn in your most recent scripture-study session?");
        _promptList.Add("List your goals for this week.");
        _promptList.Add("List ways in which you can draw nearer unto God this week.");

        _unusedPrompts.AddRange(_promptList);
    }

    // Behaviors
    public void RunListingActivity()
    {
        this.DisplayDescription();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();

        string prompt = ChoosePrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Thread.Sleep(2000);

        Console.WriteLine("Activity will begin shortly!");
        this.AnimateCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            currentTime = DateTime.Now;
        }

        this.ActivityCompletionMessage();
    }
}