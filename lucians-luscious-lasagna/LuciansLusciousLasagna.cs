class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    public int RemainingMinutesInOven(int actualTimeInOven) => this.ExpectedMinutesInOven() - actualTimeInOven;
    public int PreparationTimeInMinutes(int layers) => layers * 2;
    public int ElapsedTimeInMinutes(int layers, int minutesInOven) => this.PreparationTimeInMinutes(layers) + minutesInOven;
}
