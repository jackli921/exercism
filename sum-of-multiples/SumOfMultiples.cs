using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    // public static int Sum(IEnumerable<int> multiples, int max) => multiples.Where(n => n != 0).SelectMany(n => Enumerable.Range(1, max - 1).Where(x => x % n == 0)).Distinct().Sum();
    public static int Sum(IEnumerable<int> multiples, int max) =>
        Enumerable.Range(0, max).Where(num => multiples.Any(m => m != 0 && num % m == 0)).Sum();
}