
class WritingAssignment : Assignment
{
    // Attributes
    private string _title;
    
    // Constructors
    public WritingAssignment() : base()
    {
        _title = "Undefined";
    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    
    // Behaviors
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}