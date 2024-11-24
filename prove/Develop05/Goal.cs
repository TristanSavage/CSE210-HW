public abstract class Goal
{
    // Attributes
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _goalComplete;
    protected string _status;

    // Constructors
    public Goal()
    {
        _goalComplete = false;

        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public Goal(string type, string name, string description, int points, bool goalComplete, string status)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _goalComplete = goalComplete;
        _status = status;
    }

    // Methods
    public abstract int CompleteGoal();

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[{_status}] {_name} ({_description})");
    }

    public bool GetGoalCompletion()
    {
        return _goalComplete;
    }

    public string GetGoalType()
    {
        return  _type;
    }

    public virtual List<object> GetGoalInfo()
    {
        List<object> goalInfo = new List<object>();

        goalInfo.Add(_type);
        goalInfo.Add(_name);
        goalInfo.Add(_description);
        goalInfo.Add(_points);
        goalInfo.Add(_goalComplete);
        goalInfo.Add(_status);

        return goalInfo;
    }
}