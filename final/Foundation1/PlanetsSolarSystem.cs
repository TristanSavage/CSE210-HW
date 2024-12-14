using static System.Math;

public class PlanetsSolarSystem : CoreSolarSystem
{
    // NOTE: Masses are scaled according to Sun mass ratio found in CoreSolarSystem class
    // Attributes
    private double _MercuryMass;
    private double _VenusMass;
    private double _EarthMass;
    private double _MarsMass;
    private double _JupiterMass;
    private double _SaturnMass;
    private double _UranusMass;
    private double _NeptuneMass;

    // Constructors
    public PlanetsSolarSystem(SolarSystemManager SSM) : base(SSM)
    {
    _MercuryMass = 3.3e23*_SunMassRatio;
    _VenusMass = 4.9e24*_SunMassRatio;
    _EarthMass = 6e24*_SunMassRatio;
    _MarsMass = 6.4e23*_SunMassRatio;
    _JupiterMass = 1.9e27*_SunMassRatio;
    _SaturnMass = 5.7e26*_SunMassRatio;
    _UranusMass = 8.7e25*_SunMassRatio;
    _NeptuneMass = 1.0e26*_SunMassRatio;

    GeneratePlanets(SSM);
    }

    // Methods
    public void GeneratePlanets(SolarSystemManager SSM)
    {
        GenerateEarth(SSM);
        GenerateMercury(SSM);
        GenerateVenus(SSM);
        GenerateMars(SSM);
        GenerateJupiter(SSM);
        GenerateSaturn(SSM);
        GenerateUranus(SSM);
        GenerateNeptune(SSM);
    }

    public void GenerateEarth(SolarSystemManager SSM)
    {      
        Planet Earth = new Planet("Earth", _EarthMass, 1,0,0,2*PI);
        SSM.AddBody(Earth);
    }

    public void GenerateMercury(SolarSystemManager SSM)
    {
        Planet Mercury = new Planet("Mercury", _MercuryMass, 0.4,0,0,10.1);
        SSM.AddBody(Mercury);
    }
    
    public void GenerateVenus(SolarSystemManager SSM)
    {
        Planet Venus = new Planet("Venus", _VenusMass, 0.7,0,0,7.389);
        SSM.AddBody(Venus);
    }

    public void GenerateMars(SolarSystemManager SSM)
    {
        Planet Mars = new Planet("Mars", _MarsMass, 1.5,0,0,5.08);
        SSM.AddBody(Mars);
    }
    
    public void GenerateJupiter(SolarSystemManager SSM)
    {
        Planet Jupiter = new Planet("Jupiter", _JupiterMass, 5.2,0,0,2.755);
        SSM.AddBody(Jupiter);
    }

    public void GenerateSaturn(SolarSystemManager SSM)
    {
        Planet Saturn = new Planet("Saturn", _SaturnMass, 9.5,0,0,2.045);
        SSM.AddBody(Saturn);
    }

    public void GenerateUranus(SolarSystemManager SSM)
    {
        Planet Uranus = new Planet("Uranus", _UranusMass, 19, 0, 0, 1.437);
        SSM.AddBody(Uranus);
    }

    public void GenerateNeptune(SolarSystemManager SSM)
    {
        Planet Neptune = new Planet("Neptune", _NeptuneMass, 30,0,0,1.146);
        SSM.AddBody(Neptune);
    }

}