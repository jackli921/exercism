using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old) =>
        old
            .SelectMany(pairs => pairs.Value, (pairs, letter) => (letter, pairs.Key))
            .ToDictionary(pair => pair.letter.ToLower(), pair => pair.Key);
}