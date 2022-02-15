namespace Lesson;

public class Monkey // Super Class
{
    public string OtherName { get; set; }
    public Monkey(string name, string surname)
    {
        Name = name;
        Surname = surname;
        

        Console.WriteLine("Monkey Olusturuldu");
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public int Length { get; set; }
    
    protected void Eat()
    {
        Console.WriteLine($"I'm eating... {Name}");
    }
}


// SubClass
public class Human : Monkey
{
    public int Age { get; set; }
    
    public Human(string name, string surname, int age): base(name, surname)
    {
        Name = name;
        Surname = surname;
        Age = age;

        Console.WriteLine("Human Olusturuldu");
    }
    
    public void Think()
    {
        Console.WriteLine($"I'm thinking... I'm {Name} I'm {Age} years old");
    }

    
}


public class ChildHuman : Human
{
    public ChildHuman(string name, string surname, int age) : base(name, surname, age)
    {
        Console.WriteLine("ChildHuman Olusuturuldu");
    }
    
    public void Cry()
    {
        Console.WriteLine($"I'm crying... I'm {Name}");
        Eat();
        Think();
    }
    
    
}