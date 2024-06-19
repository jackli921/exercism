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
    
    // incorrect/original - for comparison 
    public bool Equals(FacialFeatures other) =>
        other != null &&
        EyeColor == other.EyeColor &&
        PhiltrumWidth == other.PhiltrumWidth;
    
    
    // correct/current
    // overrides the default Object.Equals method, which compares reference equality,
    // so that we compare the value equality of individual properties on the object
    
    public override bool Equals(object obj) => //compare value equality of individual properties
        obj is FacialFeatures other &&
        EyeColor == other.EyeColor &&
        PhiltrumWidth == other.PhiltrumWidth;

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

    
    // in this incorrect implementation of the Equals method below
    // we are calling on the .Equals() method of FacialFeatures object
    // However, since it is a reference based object and we did not 
    // use override keyword in the implementation of the Equals() method
    // the method being called was still the default implementation of the Equals()
    // method inherited from the Object class, which compares reference equality, not value equality.
    
    public bool Equals(Identity other) =>
        other != null &&
        this.Email.Equals(other.Email) &&
        this.FacialFeatures.Equals(other.FacialFeatures); 
    
    
    // We override the Equals and GetHashCode methods for 
    // reference types to provide a custom implementation that 
    // compares the relevant property values for equality and
    // generates a hash code based on those property values
    
    public override bool Equals(object obj) =>
        obj is Identity other &&
        this.Email.Equals(other.Email) &&
        this.FacialFeatures.Equals(other.FacialFeatures);

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
        return _registeredIdentities.Add(identity);
    }

    public bool IsRegistered(Identity identity) => _registeredIdentities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => Object.ReferenceEquals(identityA, identityB);
}
