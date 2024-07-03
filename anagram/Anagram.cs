using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private string _base;
    public Anagram(string baseWord)
    {
        _base = baseWord;
    }

    public string[] FindAnagrams(IEnumerable<string> potentialMatches)
    {
        return potentialMatches.Where(AreAnagrams).ToArray();
    }

    public bool AreAnagrams(string candidate)
    {
        return SortedLowerCase(candidate) == SortedLowerCase(_base) && IsSelf(candidate);
    }

    public bool IsSelf(string candidate)
    {
        return !string.Equals(candidate, _base, StringComparison.OrdinalIgnoreCase);
    }

    private static string SortedLowerCase(string word) => new (word.ToLower().OrderBy(x => x).ToArray());

}