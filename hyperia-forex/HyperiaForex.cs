using System;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }
    
    // TODO: implement equality operators
    public static bool operator ==(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException();
        }
        return a.amount == b.amount;
    }

    public static bool operator !=(CurrencyAmount a, CurrencyAmount b)
    {
        return !(a == b);
    }

    public static bool operator >(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
            throw new ArgumentException();
        return a.amount > b.amount;
    }

    public static bool operator <(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
            throw new ArgumentException();
        return a.amount < b.amount;
    }

    public static CurrencyAmount operator +(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
            throw new ArgumentException();
        return (new CurrencyAmount(a.amount + b.amount, a.currency));
    }
    public static CurrencyAmount operator -(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
            throw new ArgumentException();
        return (new CurrencyAmount(a.amount - b.amount, a.currency));
    }
    public static CurrencyAmount operator *(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
            throw new ArgumentException();
        return (new CurrencyAmount(a.amount * b.amount, a.currency));
    }
    public static CurrencyAmount operator /(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
            throw new ArgumentException();
        return (new CurrencyAmount(a.amount / b.amount, a.currency));
    }

    public static explicit operator double(CurrencyAmount currencyAmount)
    {
        return (double)currencyAmount.amount;
    }

    public static implicit operator decimal(CurrencyAmount currencyAmount)
    {
        return (decimal)currencyAmount.amount;
    }
    
}
