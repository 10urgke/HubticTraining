namespace SuggestEyeColor;

public class Man : Parent
{
    public int Power { get; private set; }
    
    public Man(string name, string eyeColor) : base(name, eyeColor, true)
    {
        Power = 50;
    }



    public void GYM()
    {
        Console.WriteLine("Spor Yaptım Abi...");

        Power += 5;
    }
    
    
}