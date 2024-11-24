public class EternalGoal : Goal
{
    // Attributes

    // Constructors
    public EternalGoal() : base()
    {
        _type = "EternalGoal";
        _status = "E";
    }

    public EternalGoal(string type, string name, string description, int points, bool goalComplete, string status) : base(type,name,description,points,goalComplete,status)
    {
    }

    // Methods
    public override int CompleteGoal()
    {
        return _points;
    }
}