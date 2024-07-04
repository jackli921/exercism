using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static SortedDictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        // iterate through the keys of old
        // for each value, add new pair to new dictionary 
        // sort 
        SortedDictionary<string, int> newDict = new();

        foreach (var key in old.Keys)
        {
            foreach (var s in old[key])
            {
                newDict.Add(s.ToLower(), key);
            }
        }
        return newDict;
    }
}