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
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object X) 
    {
        if(X is null) return false;
        if (object.ReferenceEquals(this, X)) return true;

        var Y = X as FacialFeatures;
        
        return EyeColor == Y.EyeColor && PhiltrumWidth.Equals(Y.PhiltrumWidth);        
    }

    public override int GetHashCode()
    {
        int hashcode = 10;
        hashcode = hashcode * 25 + EyeColor.GetHashCode();
        hashcode = hashcode * 25 + PhiltrumWidth.GetHashCode();
        return hashcode;
    }
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
    public override bool Equals(object X) 
    {
        if(X is null) return false;
        if (object.ReferenceEquals(this, X)) return true;

        var Y = X as Identity;
        
        return Email == Y.Email && Y.FacialFeatures.Equals(FacialFeatures); 
    }

    public override int GetHashCode()
    {
        int hashcode = 10;
        hashcode = hashcode * 25 + Email.GetHashCode();
        hashcode = hashcode * 25 + FacialFeatures.GetHashCode();
        return hashcode;
    }
}

public class Authenticator
{
    private readonly HashSet<Identity> identities = new HashSet<Identity>(); 
    
    private Identity Admin = new("admin@exerc.ism", new FacialFeatures("green", 0.9m));
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => 
        faceA.Equals(faceB);

    public bool IsAdmin(Identity identity) => 
        identity.Equals(Admin);

    public bool Register(Identity identity) => 
        identities.Add(identity);

    public bool IsRegistered(Identity identity) => 
        identities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) =>
        object.ReferenceEquals(identityA, identityB);
}
