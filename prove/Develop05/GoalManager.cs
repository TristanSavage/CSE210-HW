public class GoalManager
{
    // Attributes
    private List<Goal> _goalsList = new List<Goal>();
    private int _totalPoints;
    // Constructors
    public GoalManager()
    {
        _totalPoints = 0;
    }

    // Methods
    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void AddToList(Goal goal)
    {
        _goalsList.Add(goal);
    }

    public void DisplayAllGoals()
    {
        Console.WriteLine();
        Console.WriteLine("Your Goals:");
        int i = 1;
        foreach (Goal goal in _goalsList)
        {
            Console.Write($"{i}. ");

            goal.DisplayGoal();
            i += 1;
        }
    }

    public void CompleteAGoal()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine());

        int i = 1;
        foreach (Goal goal in _goalsList)
        {
            if (i == index)
            {
                if (goal.GetGoalCompletion() == true)
                {
                    Console.WriteLine("This Goal has already been Completed!");
                    Console.WriteLine("No points have been earned... :(");
                }
                else
                {
                    int pointsEarned = goal.CompleteGoal();
                    _totalPoints += pointsEarned;

                    if (goal.GetGoalType() == "NegativeGoal")
                    {
                        Console.WriteLine($"Oh no! You lost {pointsEarned} points...");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                    }
                }
            }
            i += 1;
        }
        Thread.Sleep(2000);
    }

    public void SaveToFile()
    {
        Console.WriteLine();
        Console.Write("File Name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_totalPoints}");
            
            foreach (Goal goal in _goalsList)
            {
                List<object> goalInfo = goal.GetGoalInfo();
                string type = goalInfo[0].ToString();

                if (type == "SimpleGoal")
                {
                    outputFile.WriteLine($"{goalInfo[0]}|{goalInfo[1]}~{goalInfo[2]}~{goalInfo[3]}~{goalInfo[4]}~{goalInfo[5]}");
                }

                if (type == "EternalGoal"||type== "NegativeGoal")
                {
                    outputFile.WriteLine($"{goalInfo[0]}|{goalInfo[1]}~{goalInfo[2]}~{goalInfo[3]}~{goalInfo[4]}~{goalInfo[5]}");
                }

                if (type == "CheckListGoal")
                {
                    outputFile.WriteLine($"{goalInfo[0]}|{goalInfo[1]}~{goalInfo[2]}~{goalInfo[3]}~{goalInfo[4]}~{goalInfo[5]}~{goalInfo[6]}~{goalInfo[7]}~{goalInfo[8]}");
                }
                else
                {
                    // outputFile.WriteLine($"Something Broke...  internal goals list length: {_goalsList.Count}");
                }
            }
        }

        Console.WriteLine("File Save --> Successful!");
    }

    public void LoadFromFile()
    {
        Console.WriteLine();
        Console.Write("File Name: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _totalPoints += int.Parse(lines[0]);

        int index = 0;
        foreach (string line in lines)
        {
            if (index > 0)
            {
                string[] type0_other1 = line.Split("|");
                string type = type0_other1[0];
                string other = type0_other1[1];

                string[] parts = other.Split("~");

                if (type == "SimpleGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool goalComplete = bool.Parse(parts[3]);
                    string status = parts[4];
                    
                    SimpleGoal newSimpleGoal = new SimpleGoal(type,name,description,points,goalComplete,status);
                    _goalsList.Add(newSimpleGoal);
                }

                if (type == "EternalGoal"||type == "NegativeGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool goalComplete = bool.Parse(parts[3]);
                    string status = parts[4];
                    
                    EternalGoal newEternalGoal = new EternalGoal(type,name,description,points,goalComplete,status);
                    _goalsList.Add(newEternalGoal);
                }

                if (type == "CheckListGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    int bonusPoints = int.Parse(parts[3]);
                    int checkNumber = int.Parse(parts[4]);
                    int checkCount = int.Parse(parts[5]);
                    bool goalComplete = bool.Parse(parts[6]);
                    string status = parts[7];

                    CheckListGoal newCheckListGoal = new CheckListGoal(type,name,description,points,goalComplete,status,bonusPoints,checkNumber,checkCount);
                    _goalsList.Add(newCheckListGoal);
                }
            }
        index += 1;
        }
        Console.WriteLine("File load --> Successful!");
    }
}