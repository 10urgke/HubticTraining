namespace SuggestEyeColor;

public class Child: Human
{
    
    public int Childness { get; private set; }

    public int ChildnessAge
    {
        get => GetAge();
        set
        {
            Childness -= 10;
            SetAge(value);
        }
    }

    public Child(string name): base(name)
    {
        Childness = 100;
        ChildnessAge = GetAge();
    }


    private Man father;
    private Woman mother;
    public Child(Man father, Woman mother): base("")
    {
        this.father = father;
        this.mother = mother;
    }
    
    

    public void Growth()
    {
        ChildnessAge++;
    }
    
    public string GetEyeColor()
    {
        return base.GetEyeColor();
    }

    public string GetEyeColorWith()
    {
        if (mother.GetEyeColor() == "Brown" && father.GetEyeColor() == "Blue")
        {
            return "Brown";
        } else if (mother.GetEyeColor() == "Brown" && father.GetEyeColor() == "Brown")
        {
            return "Brown";
        }
        else
        {
            return "Blue";
        }
    }
    
}