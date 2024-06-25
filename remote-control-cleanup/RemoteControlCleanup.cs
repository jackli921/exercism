public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }

    private Speed currentSpeed;

    public CarTelemetry Telemetry { get; private set; }

    public RemoteControlCar()
    { 
        this.Telemetry = new CarTelemetry(this);
    }

    public class CarTelemetry: ITelemetry
    {
        RemoteControlCar _parent;
        public CarTelemetry(RemoteControlCar parent)
        {
            _parent = parent;
        }

        public void Calibrate()
        {

        }

        public bool SelfTest()
        {
            return true;
        }

        public void ShowSponsor(string sponsorName)
        {
            _parent.SetSponsor(sponsorName);
        }

        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
            if (unitsString == "cps")
            {
                speedUnits = SpeedUnits.CentimetersPerSecond;
            }

            _parent.SetSpeed(new Speed(amount, speedUnits));
        }
    }
    
    public string GetSpeed()
    {
        return currentSpeed.ToString();
    }

    private void SetSponsor(string sponsorName)
    {
        CurrentSponsor = sponsorName;

    }

    private void SetSpeed(Speed speed)
    {
        currentSpeed = speed;
    }

    
    public struct Speed
    {
        public decimal Amount { get; }
        public SpeedUnits SpeedUnits { get; }

        public Speed(decimal amount, SpeedUnits speedUnits)
        {
            Amount = amount;
            SpeedUnits = speedUnits;
        }

        public override string ToString()
        {
            string unitsString = "meters per second";
            if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
            {
                unitsString = "centimeters per second";
            }

            return Amount + " " + unitsString;
        }
    }

    public enum SpeedUnits
    {
        MetersPerSecond,
        CentimetersPerSecond
    }
}

public interface ITelemetry
{
    public void Calibrate();
    public bool SelfTest();
    public void ShowSponsor(string sponsorName);
    public void SetSpeed(decimal amount, string unitsString);
}


