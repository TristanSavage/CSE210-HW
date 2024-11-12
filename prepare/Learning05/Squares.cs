public class Square : Shape
{
    // Attributes
    private double _sideLength;

    // Constructors
    public Square(string color, double sideLength) : base(color)
    {
        _sideLength = sideLength;
    }

    // Methods
    public override double GetArea()
    {
        return _sideLength*_sideLength;
    }
}