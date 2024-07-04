using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static SortedDictionary<string, int> Transform(Dictionary<int, string[]> old) =>
        new(old
            .SelectMany(pairs => pairs.Value.Select(letter => (letter.ToLower(), pairs.Key)))
            .ToDictionary(tuple => tuple.Item1, tuple => tuple.Item2));
}