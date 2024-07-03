using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> result = new(){
                { 'A', 0 },
                { 'C', 0 },
                { 'G', 0 },
                { 'T', 0 },
            };

        if (sequence.Length == 0) return result;
        
        foreach (var s in sequence)
        {
            if (result.ContainsKey(s))
                result[s]++;
            else
            {
                throw new ArgumentException();
            }
        }
        return result;
    }
}
