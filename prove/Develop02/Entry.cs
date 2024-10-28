


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