public class PopulateSolarSystem
{
    // Attributes
    private int _number;
    private bool _large;
    private float _mass;

    // Constructors
    PopulateSolarSystem(int number, string size)
    {
        _number = number;
        
        switch (size)
        {
            case "large":
                _large = true;
                break;

            case "Large":
                _large = true;
                break;

            case "l":
                _large = true;
                break;

            case "L":
                _large = true;
                break;

            default:
                _large = false;
                break;
        }
    }

    // Methods
}