using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        return word.Where(char.IsLetter).GroupBy(char.ToLower).All(g => g.Count() == 1);

        /*return word.ToLower().Where(x => char.IsLetter(x)).ToList().Count ==
                   word.ToLower().Where(x => char.IsLetter(x)).Distinct().ToList().Count;*/

        /*var lowerLetters = word.ToLower().Where(x => char.IsLetter(x)).ToArray();
        return lowerLetters.Length == lowerLetters.Distinct().Count();*/
    }
}
