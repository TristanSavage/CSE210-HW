public class Asteroid : CelestialBody
{
    // Attributes

    // Constructors
    public Asteroid(string name, double x, double y, double vX, double vY) : base(name, x, y, vX, vY)
    {
        _mass = 1.974e-16;
    }

    // Methods
}