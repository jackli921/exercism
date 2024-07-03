using System;
using System.Linq;

public class Anagram
{
    private string _base;
    public Anagram(string baseWord)
    {
        _base = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        return potentialMatches.Where(candidate => candidate.ToLower() != _base.ToLower() && AreAnagrams(candidate, _base)).ToArray();
    }

    public bool AreAnagrams(string candidate, string baseWord)
    {
        var sortedLowerCaseCandidate = string.Concat(candidate.ToLower().OrderBy(x => x));
        var sortedLowerCaseBaseWord = string.Concat(baseWord.ToLower().OrderBy(x => x));

        return sortedLowerCaseCandidate == sortedLowerCaseBaseWord;
    }
}