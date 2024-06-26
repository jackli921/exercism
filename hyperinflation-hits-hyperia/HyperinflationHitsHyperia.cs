using System;
using System.Collections.Immutable;
using System.Threading;

public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        long sum = 0;
        try
        {
             sum = checked(@base * multiplier);
        }
        catch (OverflowException e)
        {
            return "*** Too Big ***";
        }
        return $"{sum}";
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        var product = @base * multiplier;
        return product == float.PositiveInfinity ? "*** Too Big ***" : product.ToString();
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        decimal sum = 0;
        try
        {
            sum = salaryBase * multiplier;
        }
        catch (OverflowException e)
        {
            return "*** Much Too Big ***";
        }
        return $"{sum}";
    }
}
