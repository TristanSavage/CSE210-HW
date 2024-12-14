using static System.Math;

public class SolarSystemManager
{
    // Attributes
    private double _G = 1;
    private List<CelestialBody> _allBodies = new List<CelestialBody>();

    // Constructors

    // Methods
    public void AddBody(CelestialBody CB)
    {
        _allBodies.Add(CB);
    }

    public void ClearSystemManager()
    {
        _allBodies.Clear();
    }

    public void DisplayStatusALL(string title)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Status ID - {title}:");
        foreach (CelestialBody CB in _allBodies)
        {
            CB.DisplayName();
            CB.DisplayLocalStatus();
            Console.WriteLine();
        }
    }

    public void DisplayStatus(string title, string CB_Name)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Local Status ID - {title}:");
        foreach (CelestialBody CB in _allBodies)
        {
            if (CB.GetName() == CB_Name)
            {
                CB.DisplayName();
                CB.DisplayLocalStatus();
                Console.WriteLine();
            }
        }
    }


    public void RunRK4(double t, double tf, double dt)
    {
        while (t < tf)
        {
            foreach (CelestialBody body in _allBodies)
            {
                if (body.GetImmovability() == false)
                {
                    string name = body.GetName();
                    double mass = body.GetMass();
                    double[] bodyArray = body.GetArray();

                    double[] adaptiveArray = new double[4];
                    Array.Copy(bodyArray, adaptiveArray, 4);

                    double[] k1 = CalculateDerivatives(adaptiveArray,name,mass);
                    for (int i = 0; i < 4; i++)
                    {
                        adaptiveArray[i] = bodyArray[i] + dt*k1[i]/2;
                    }
                    
                    double[] k2 = CalculateDerivatives(adaptiveArray,name,mass);
                    // Console.WriteLine($"k2 = [{k2[0]}, {k2[1]}, {k2[2]}, {k2[3]}]");
                    for (int i = 0; i < 4; i++)
                    {
                        adaptiveArray[i] = bodyArray[i] + dt*k2[i]/2;
                        // Console.WriteLine($"OG Array element = {bodyArray[i]}, Scaled k2 Array element = {dt*k2[i]/2}");
                    }
                    
                    double[] k3 = CalculateDerivatives(adaptiveArray,name,mass);
                    for (int i = 0; i < 4; i++)
                    {
                        adaptiveArray[i] = bodyArray[i] + dt*k3[i];
                    }
                    
                    double[] k4 = CalculateDerivatives(adaptiveArray,name,mass);
                    
                    for (int i = 0; i < 4; i++)
                    {
                        bodyArray[i] += dt*(k1[i] + 2*k2[i] + 2*k3[i] + k4[i])/6;
                    }

                    body.SetArray(bodyArray);
                    body.UpdateLists(bodyArray);
                }
            }

            t += dt;
        }




    }

    public double[] CalculateDerivatives(double[] array0, string name, double mass)
    {
        double x0 = array0[0];
        double y0 = array0[1];
        double vX = array0[2];
        double vY = array0[3];
        // Console.WriteLine($"Input array = [{x0}, {y0}, {vX}, {vY}]");

        double aX = 0;
        double aY = 0;

        foreach (CelestialBody CelestialBody in this._allBodies)
        {
            string CB_Name = CelestialBody.GetName();
            if (CB_Name == name)
                {}

            else
            {
                // Console.WriteLine(CB_Name);
                double CB_Mass = CelestialBody.GetMass();

                double[] CB_Array = CelestialBody.GetArray();
                double CB_x = CB_Array[0];
                double CB_y = CB_Array[1];
                double CB_vX = CB_Array[2];
                double CB_vY = CB_Array[3];
                // Console.WriteLine($"Earth: x = {x0}, y = {y0}");
                // Console.WriteLine($"Sun: x = {CB_x}, y = {CB_y}");


                double x = CB_x - x0;
                double y = CB_y - y0;
                double r = Sqrt(x*x + y*y);
                // Console.WriteLine($"x = {x}, y = {y}, r = {r}");

                aX += _G*CB_Mass * (x/r/r/r);
                aY += _G*CB_Mass * (y/r/r/r);
            }    
 
        }

        double[] arrayFinal = new double[4];
        arrayFinal[0] = vX;
        arrayFinal[1] = vY;
        arrayFinal[2] = aX;
        arrayFinal[3] = aY;

        // Console.WriteLine($"Derivs = [{arrayFinal[0]},{arrayFinal[1]},{arrayFinal[2]},{arrayFinal[3]}]");
        // Console.WriteLine();
        return arrayFinal;
    }
}