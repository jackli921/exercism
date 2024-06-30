using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    private static string Alphabet  => new string(Enumerable.Range('a', 26).Select(x => (char)x).ToArray());

    public static bool IsPangram(string input)
    {
        var lowerCaseInput = input.ToLower();
        foreach (var letter in Alphabet)
        {
            if (!lowerCaseInput.Contains(letter)) return false;
        }
        return true;
    }
}
