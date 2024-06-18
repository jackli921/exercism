using System;
using System.Runtime.CompilerServices;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public readonly int speed;
    public readonly int batteryDrain;
    private int distanceDriven;
    private int batteryRemaining;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.distanceDriven = 0;
        this.batteryRemaining = 100;
    }
    
    public bool BatteryDrained() => this.batteryRemaining < batteryDrain;

    public int DistanceDriven() => this.distanceDriven;

    public void Drive()
    {
        if (batteryRemaining >= batteryDrain)
        {
            this.distanceDriven += speed;
            this.batteryRemaining -= this.batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack
{
    private readonly int distance;

    public RaceTrack(int distance) => this.distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int maxDistance = car.speed * (100 / car.batteryDrain);
        return maxDistance >= this.distance;
    }
}
