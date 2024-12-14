public class Room
{
    // Attributes
    private string _name;
    private List<SmartDevice> _devices = new List<SmartDevice>();

    // Constructor
    public Room(string name)
    {
        _name = name;
    }

    // Methods
    public void AddToList(SmartDevice Device)
    {
        _devices.Add(Device);
    }

    public void TurnOnLights()
    {
        foreach (SmartLight light in _devices)
        {
            light.TurnON();
        }
    }

    public void TurnOffLights()
    {
        foreach (SmartDevice device in _devices)
        {
            if (device is SmartLight)
            {
                device.TurnOFF();
            }
        }
    }

    public void TurnOnDevices()
    {
        foreach (SmartDevice device in _devices)
        {
            device.TurnON();
        }
    }

    public void TurnOffDevices()
    {
        foreach (SmartDevice device in _devices)
        {
            device.TurnOFF();
        }
    }

    public void ReportStatus()
    {
        int i = 1;
        string status = "OFF";
        foreach (SmartDevice device in _devices)
        {
            if (device.GetStatus() == true)
            {
                status = "ON";
            }
            Console.WriteLine($"Smart Device {i}: {device}; Status: {status}");
            i += 1;
        }
    }


}