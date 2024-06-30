using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input) => input.ToLower().Distinct().Where(char.IsLetter).Count() == 26;
}
