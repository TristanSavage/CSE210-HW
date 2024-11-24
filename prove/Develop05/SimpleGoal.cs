public class SimpleGoal : Goal
{
    // Attributes

    // Constructors
    public SimpleGoal() : base()
    {
        _type = "SimpleGoal";
        _status = " ";
    }

    public SimpleGoal(string type, string name, string description, int points, bool goalComplete, string status) : base(type,name,description,points,goalComplete,status)
    {
    }

    // Methods
    public override int CompleteGoal()
    {
        _goalComplete = true;
        _status = "X";
        return _points;
    }
}