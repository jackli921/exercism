using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // return input.ToLower().Distinct().Where(char.IsLetter).Count() == 26;
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        return alphabet.All(c => input.ToLower().Contains(c));
    }
}
