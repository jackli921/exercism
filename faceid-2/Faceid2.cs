using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(object obj)
    {
        if (obj is null || !this.GetType().Equals(obj.GetType()))
        {
            return false;
        }

        FacialFeatures other = (FacialFeatures)obj;

        return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
    }

    public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods

    public override bool Equals(object obj)
    {
        if (obj is null || !this.GetType().Equals(obj.GetType()))
        {
            return false;
        }

        Identity other = (Identity)obj;

        return Email == other.Email && FacialFeatures.EyeColor == other.FacialFeatures.EyeColor && FacialFeatures.PhiltrumWidth == other.FacialFeatures.PhiltrumWidth;
    }

    public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures);
}

public class Authenticator
{
    private HashSet<Identity> _registeredIdentities = new(); 
    private static readonly Identity _admin = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity)
    {
        if (identity is null) return false;

        return identity.Equals(_admin);
    }

    public bool Register(Identity identity)
    {
        if (_registeredIdentities.Contains(identity))
        {
            return false;
        }
        return _registeredIdentities.Add(identity);
    }

    public bool IsRegistered(Identity identity) => _registeredIdentities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => Object.ReferenceEquals(identityA, identityB);
}
