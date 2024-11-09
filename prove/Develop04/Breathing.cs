class Breathing : Activities
{
    // Attributes

    // Constructors
    public Breathing()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Behaviors
    public void RunBreathingActivity()
    {
        this.DisplayDescription();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            if (_duration <= 9)
            {
                Console.WriteLine("Breathe in...");
                this.AnimateCountDown(2);
                Console.WriteLine();

                Console.WriteLine("Now breathe out...");
                this.AnimateCountDown(3);
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Breathe in...");
                this.AnimateCountDown(4);
                Console.WriteLine();

                Console.WriteLine("Now breathe out...");
                this.AnimateCountDown(6);
                Console.WriteLine();
            }
        Console.WriteLine();
        currentTime = DateTime.Now;
        }
        
        this.ActivityCompletionMessage();
    }
}