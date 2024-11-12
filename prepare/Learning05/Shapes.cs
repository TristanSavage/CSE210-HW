public abstract class Shape
{
    // Attributes
    private string _color;

    // Constructors
    public Shape(string color)
    {
        _color = color;
    }

    //// Methods
    // Abstract
    public abstract double GetArea();

    // Non-Abstract
    public string GetColor()
    {
        return _color;
    }
}