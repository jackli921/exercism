using System;

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
    private Identity registeredIdentity;
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity)
    {
        if (identity is null) return false;

        return identity.Email == "admin@exerc.ism" 
               && identity.FacialFeatures.PhiltrumWidth == 0.9m
               && identity.FacialFeatures.EyeColor == "green";
    }

    public bool Register(Identity identity)
    {
        if (registeredIdentity is null)
        {
            registeredIdentity = identity;
            return true;            
        }
        if (registeredIdentity.Equals(identity))
        {
            return false;
        }
        return false;
    }

    public bool IsRegistered(Identity identity) => this.registeredIdentity.Equals(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => Object.ReferenceEquals(identityA, identityB);
}
