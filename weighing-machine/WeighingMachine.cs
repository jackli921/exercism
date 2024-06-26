using System;

class WeighingMachine
{
    private double _precision;

    public double Precision
    {
        get { return _precision; }
        private set { _precision = value; }
    }

    private double _weight;

    public double Weight
    {
        get { return _weight; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            _weight = value;
        }
    }
    public string DisplayWeight => $"{(Weight - TareAdjustment).ToString($"F{Precision}")} kg";
    public double TareAdjustment { get; set; } = 5.0;

public WeighingMachine(double precision) => _precision = precision;
}
