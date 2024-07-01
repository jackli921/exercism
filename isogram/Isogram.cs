using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        /*return word.ToLower().Where(x => char.IsLetter(x)).ToList().Count == 
                   word.ToLower().Where(x => char.IsLetter(x)).Distinct().ToList().Count;*/
        
        return word.ToLower().Where(x => char.IsLetter(x)).ToArray().Length ==
               word.ToLower().Where(x => char.IsLetter(x)).Distinct().ToArray().Length;
    }
}
