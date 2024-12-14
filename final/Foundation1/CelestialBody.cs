public abstract class CelestialBody
{
    // Attributes
    private bool _immovable;
    private string _name;
    protected double _mass;

    private double[] _array = new double[4];

    private List<double> _xPositions = new List<double>();
    private List<double> _yPositions = new List<double>();
    private List<double> _xVelocities = new List<double>();
    private List<double> _yVelocities = new List<double>();

    // Constructors
    public CelestialBody(string name, double mass, bool immovable)
    {
        _name = name;
        _mass = mass;
        _immovable = immovable;

        _array[0] = 0;
        _array[1] = 0;
        _array[2] = 0;
        _array[3] = 0;

        _xPositions.Add(_array[0]);
        _yPositions.Add(_array[1]);
        _xVelocities.Add(_array[2]);
        _yVelocities.Add(_array[3]);
    }

    public CelestialBody(string name, double mass, double x, double y, double vX, double vY)
    {
        _name = name;
        _mass = mass;
        _immovable = false;

        _array[0] = x;
        _array[1] = y;
        _array[2] = vX;
        _array[3] = vY;

        _xPositions.Add(_array[0]);
        _yPositions.Add(_array[1]);
        _xVelocities.Add(_array[2]);
        _yVelocities.Add(_array[3]);
    }

    public CelestialBody(string name, double x, double y, double vX, double vY)
    {
        _name = name;
        _immovable = false;

        _array[0] = x;
        _array[1] = y;
        _array[2] = vX;
        _array[3] = vY;
    }

    // Methods
    public void DisplayName()
    {
        Console.WriteLine($"    {_name}");
    }

    public void DisplayLocalStatus()
    {
        Console.WriteLine($"        x = {_array[0]}, y = {_array[1]}");
    }

    public string GetName()
    {
        return _name;
    }

    public double GetMass()
    {
        return _mass;
    }

    public bool GetImmovability()
    {
        return _immovable;
    }

    public double[] GetArray()
    {

        return _array;
    }

    public void SetArray(double[] updatedArray)
    {
        _array = updatedArray;
    }

    public void UpdateLists(double[] array)
    {
        _xPositions.Add(array[0]);
        _yPositions.Add(array[1]);
        _xVelocities.Add(array[2]);
        _yVelocities.Add(array[3]);
    }

    // For testing purposes
    public void PrintLists()
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine();
        for (int i = 0; i < _xPositions.Count(); i++)
        {
            Console.WriteLine($"    x = {_xPositions[i]}");
            // Console.WriteLine($"    y = {_yPositions[i]}");
            Console.WriteLine();
        }
    }
}