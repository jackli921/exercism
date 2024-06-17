using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };
    
    public int Today() => this.birdsPerDay.LastOrDefault();

    public void IncrementTodaysCount() => this.birdsPerDay[^1]++;

    public bool HasDayWithoutBirds() => Array.Exists(this.birdsPerDay, e => e == 0);

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            total += this.birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays() => this.birdsPerDay.Count(c => c >= 5);
}
