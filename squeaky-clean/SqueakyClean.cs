using System;
using System.Globalization;
using System.Linq;
using System.Text;

public static class Identifier
{
    private const string LowerCaseGreekLetters = "αβγδεζηθικλμνξοπρστυφχψω";

    public static string Clean(string identifier)
    {
        var cleaned = new StringBuilder();
        
        for (int i = 0; i < identifier.Length; i++)
        {
            char c = identifier[i];

            if (LowerCaseGreekLetters.Contains(c))
                continue;

            if (c == ' ')
                cleaned.Append("_");
            else if (char.IsControl(c))
                cleaned.Append("CTRL");
            else if (i > 0 && identifier[i - 1] == '-')
                cleaned.Append(char.ToUpper(c));
            else if (char.IsLetter(c))
                cleaned.Append(c);
        }
        return cleaned.ToString();
    }
}
