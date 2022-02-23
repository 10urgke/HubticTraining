namespace SuggestEyeColor;



public interface Alive
{
    void Breath();
}

public interface Animal : Alive
{
    void DontThink();
}

public interface IHuman : Alive
{
    public string Name { get; set; }
    int Age { get; set; }
    string EyeColor { get; set; }

    void Think();
}

public class Onur : IHuman
{
    public void Breath()
    {
        Console.WriteLine("Ben Nefes Almadan Yasayabilirim");
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string EyeColor { get; set; }
    public void Think()
    {
        Console.WriteLine("Ben Herzaman Düsünürüm");
    }
}

public class Fatih : IHuman
{
    public void Breath()
    {
        Console.WriteLine("Ben Nefes Almadan Ölürüm");
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string EyeColor { get; set; }
    public void Think()
    {
        Console.WriteLine("Benim Düsünmeye Ayıracak Vaktim Yok abi...");
    }
}


public class Human : IHuman 
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string EyeColor { get; set; }
    
    public void Think()
    {
        Console.WriteLine("I'm thinking");
    }


    public Human(string name)
    {
        Name = name;
        Age = 0;
    }

    public Human(string name, string eyeColor)
    {
        Name = name;
        EyeColor = eyeColor;
    }
    

    public string GetName()
    {
        return Name;
    }

    public virtual string GetHairColor()
    {
        return "Black";
    }


    public int GetAge()
    {
        return Age;
    }

    protected void SetAge(int age)
    {
        if (age > 0 && age > Age)
        {
            Age = age;
        }
    } 


    public string GetEyeColor()
    {
        return EyeColor;
    }

    public void Breath()
    {
        Console.WriteLine("I'm Breathing...");
    }
}