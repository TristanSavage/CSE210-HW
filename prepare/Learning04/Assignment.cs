
class Assignment
{
    // Attributes
    protected string _studentName;
    private string _topic;

    // Constructors
    public Assignment()
    {
        _studentName = "Undefined";
        _topic = "Undefined";
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Behaviors
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}