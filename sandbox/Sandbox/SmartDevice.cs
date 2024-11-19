public abstract class SmartDevice
{
    // Attributes
    private string _name;
    private bool _status;
    private DateTime _startTime;

    // Constructor
    public SmartDevice(string name)
    {
        _name = name;
        _status = false;
    }

    public SmartDevice(string name, string status)
    {
        _name = name;

        if (status == "True" || status == "T" || status == "true" || status == "t")
        {
            _status = true;
        }
        else
        {
            _status = false;
        }
    }

    // Methods
    public bool GetStatus()
    {
        return _status;
    }

    public void TurnON()
    {
        if (_status == false)
        {
        _status = true;
        }
        else
        {
        }
    }

    public void TurnOFF()
    {
        if (_status == true)
        {
        _status = false;
        }
        else
        {
        }
    }

    public void SwitchDeviceStatus()
    {
        if (_status == true)
        {
            _status = false;

        }
        if (_status == false)
        {
            _status = true;
        }
    }

    public void BeginTimer()
    {
        if (_status == true)
        {
            DateTime _startTime = DateTime.Now;
        }
    }

    public TimeSpan CheckTime()
    {
        TimeSpan duration = _startTime - _startTime;
        if (_status == true)
        {
            DateTime currentTime = DateTime.Now;
            duration = currentTime - _startTime;
        }

        return duration;
    }
}