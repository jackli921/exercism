using System;

class RemoteControlCar
{
    private int _meteresDriven = 0;
    private int _batteryPercentage = 100;
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {_meteresDriven} meters";

    public string BatteryDisplay() => _batteryPercentage > 0 ? $"Battery at {_batteryPercentage}%" : "Battery empty";

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _meteresDriven += 20;
            _batteryPercentage -= 1;            
        }
    }
}
