using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList() => new ();

    public static List<string> GetExistingLanguages() => new () { "C#", "Clojure", "Elm" };

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages.ToList();
    }

    public static int CountLanguages(List<string> languages) => languages.Count();

    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages)
    { 
        languages.Reverse();
        return languages.ToList();
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0) return false;
        if (languages.FirstOrDefault() == "C#") return true;

        if ((languages.Count == 2 || languages.Count == 3) && languages[1] == "C#") return true;
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages.ToList();
    }

    public static bool IsUnique(List<string> languages)
    {
        var set = new HashSet<string>();
        foreach (var str in languages)
        {
            if (!set.Add(str))
            {
                return false;
            }
        }
        return true;
    }
}
