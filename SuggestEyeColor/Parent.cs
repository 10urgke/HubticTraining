namespace SuggestEyeColor;

public class Parent: Human
{
    private bool isMan = false;
    public Parent(string name, string eyeColor, bool isMan) : base(name, eyeColor)
    {
        this.isMan = isMan;
    }


    private bool isSameGener(Parent parent)
    {
        return this.isMan == parent.isMan;
    }

    public new string GetHairColor()
    {
        return "BLUE";
    }

    public Child CreateChild(Parent parent, string childName)
    {
        if (isSameGener(parent))
        {
            return null;
        }
        
        
        if (GetEyeColor() == "Brown" && parent.GetEyeColor() == "Blue")
        {
            return new Child(childName);
        } else if (GetEyeColor() == "Brown" && parent.GetEyeColor() == "Brown")
        {
            return new Child(childName);
        }
        else
        {
            return new Child(childName);
        }
    }

   
}