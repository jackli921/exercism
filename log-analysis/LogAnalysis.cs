using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type

    public static string SubstringAfter(this string input, string delimiter)
    {
        return input.Split(delimiter)[1];
    }

    public static string SubstringBetween(this string input, string delimiter1, string delimiter2)
    {
        // return input.Split(delimiter1)[1].Split(delimiter2)[0];
        int startIndex = input.IndexOf(delimiter1);
        if (startIndex == -1) return string.Empty;
    
        startIndex += delimiter1.Length;
        int endIndex = input.IndexOf(delimiter2, startIndex);
        if (endIndex == -1) return string.Empty;
    
        return input.Substring(startIndex, endIndex - startIndex);
    }

    public static string Message(this string input)
    {
        return input.SubstringAfter(":").Trim();
    }

    public static string LogLevel(this string input)
    {
        return input.SubstringBetween("[","]");
    }
    
}