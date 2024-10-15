using System;

class Fraction
{
    // Attributes
    private int _top;
    private int _bottom;


    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters/Setters
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Behaviors
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        double top = _top;
        double bottom = _bottom;

        return top/bottom;
    }

}


class Program
{
    static void Main(string[] args)
    {

        // Fraction testFrac = new Fraction();
        // Fraction testFrac = new Fraction(6);
        Fraction testFrac = new Fraction(6,7);
        Console.WriteLine(testFrac.GetFractionString());

        testFrac.SetTop(12);
        int testTop = testFrac.GetTop();

        testFrac.SetBottom(17);
        int testBottom = testFrac.GetBottom();

        Console.WriteLine($"{testTop}, {testBottom}");
        Console.WriteLine($"{testFrac.GetFractionString()}, {testFrac.GetDecimalValue()}");

    }
}