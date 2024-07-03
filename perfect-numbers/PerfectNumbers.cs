using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect = 0,
    Abundant = 1,
    Deficient = -1
}

public static class PerfectNumbers
{
    public static Classification Classify(int number) =>
        (Classification)Enumerable.Range(1, number - 1).Where(i => number % i == 0).Sum().CompareTo(number);
    /*public static Classification Classify(int number)
    {
        // use a for loop, and count from the number itself down to 1
        // if the number is divisible by the current iteration number of i with a remainder of 0, then add that number to the number list
        // if not, then reduce the current iteration down by 1
        // repeat until iteration number is 1
        // all all numbers in the number list
        // if the total is equal to the argument number, then return Perfect.
        // if the total is greater than the argument, then return Abundant.
        // else return Deficient
        if (number == 1) return Classification.Deficient;
        if (number <= 0) throw new ArgumentOutOfRangeException();

        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        
        if (sum == number) return Classification.Perfect;
        if (sum > number) return Classification.Abundant;
        return Classification.Deficient;
    }*/
}
