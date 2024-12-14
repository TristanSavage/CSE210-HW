using static System.Math;

public class CoreSolarSystem
{
    // Attributes
        private double _scaledSunMass ;
        private double _SunMass;
        protected double _SunMassRatio;

    // Constructors
    public CoreSolarSystem(SolarSystemManager SSM)
    {
        _scaledSunMass = 4*PI*PI;
        _SunMass = 2e30;
        _SunMassRatio = _scaledSunMass/_SunMass;

        Star Sun = new Star("Sun",_scaledSunMass,true);
        SSM.AddBody(Sun);
    }
}