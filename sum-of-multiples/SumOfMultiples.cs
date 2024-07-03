using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) => multiples.Where(n => n != 0).SelectMany(n => Enumerable.Range(1, max - 1).Where(x => x % n == 0)).Distinct().Sum();
}