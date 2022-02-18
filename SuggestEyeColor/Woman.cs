namespace SuggestEyeColor;

public class Woman : Parent
{
    
    public int Beauty { get; private set; }
    
    public Woman(string name, string eyeColor) : base(name, eyeColor, false)
    {
        Beauty = 50;
    }



    public void HairSaloon()
    {
        Console.WriteLine("Kuaföre Gittim, Artıuk Daha Güzelim...");
        Beauty += 5;
    }
    

}