namespace SuggestEyeColor;

public class Human
{
    private string Name { get; set; }
    private int Age { get; set; }
    private string EyeColor { get; set; }
    

    public Human(string name)
    {
        Name = name;
        Age = 0;
    }
    

    public string GetName()
    {
        return Name;
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
}