using static System.Math;

public class AsteroidSolarSystem : PlanetsSolarSystem
{
    // Attributes

    // Constructors
    public AsteroidSolarSystem(SolarSystemManager SSM) : base(SSM)
    {
        GenerateAsteroid("AstGap5_1",1.78,4.709,SSM);
        GenerateAsteroid("AstGap4_1",2.065,4.372,SSM);
        GenerateAsteroid("AstGap3_1",2.502,3.972,SSM);
        GenerateAsteroid("AstGap2_1",3,3.628,SSM);
    }

    // Methods
    public void GenerateAsteroid(string name, double x, double vY, SolarSystemManager SSM)
    {
        Asteroid asteroid = new Asteroid(name,x,0,0,vY);
        SSM.AddBody(asteroid);
    }
}