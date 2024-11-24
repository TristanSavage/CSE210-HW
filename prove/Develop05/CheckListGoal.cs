public class CheckListGoal : Goal
{
    // Attributes
    private int _bonusPoints;
    private int _checkNumber;
    private int _checkCount;

    // Constructors
    public CheckListGoal() : base()
    {
        _type = "CheckListGoal";

        _status = " ";

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _checkNumber = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

        _checkCount = 0;
    }

    public CheckListGoal(string type, string name, string description, int points, bool goalComplete, string status, int bonusPoints, int checkNumber, int checkCount) : base(type,name,description,points,goalComplete,status)
    {
        _bonusPoints = bonusPoints;
        _checkNumber = checkNumber;
        _checkCount = checkCount;
    }

    // Methods
    public override int CompleteGoal()
    {
        _checkCount += 1;

        if (_checkCount == _checkNumber)
        {
            _goalComplete = true;
            _status = "X";
            return _points + _bonusPoints;
        }
        else
        {
            _status = "P";
            return _points;
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_status}] {_name} ({_description}) -- Currently Completed: {_checkCount}/{_checkNumber}");
    }

    public override List<object> GetGoalInfo()
    {
        List<object> goalInfo = new List<object>();

        goalInfo.Add(_type);
        goalInfo.Add(_name);
        goalInfo.Add(_description);
        goalInfo.Add(_points);
        goalInfo.Add(_bonusPoints);
        goalInfo.Add(_checkNumber);
        goalInfo.Add(_checkCount);
        goalInfo.Add(_goalComplete);
        goalInfo.Add(_status);
        
        return goalInfo;
    }
}