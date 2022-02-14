namespace Lesson;

public class Car
{

    private int age;

    private int _speed;

    private int rentCount = 0;

    private int driveCount
    {
        get
        {
            return drives;
        }
        
        set
        {
            Console.WriteLine($"Drive Count : {value}");
            if ((value% 5) == 0 )
            {
                age++;
            }

            drives = value;
        }
    }

    private int drives;
    

    private int Speed
    {
        get
        {
            Console.WriteLine("Speed Get Method");
            return _speed;
        }
        set
        {
            Console.WriteLine("Speed Set Method");
            if (value < 100)
            {
                this._speed = value;
            }
            else
            {
                Console.WriteLine("Hız 100 den büyük olamaz!");
            }
        }
        
    }


    public void Drive()
    {
        driveCount++;
        int currentSpeed = this.Speed;
        int drivenSpeed = currentSpeed + 5;
        
        this.Speed = drivenSpeed;

        Console.WriteLine($"Car Speed is {this.Speed}");
        Rent();
        Console.WriteLine($"Car's Age: {age}");
    }

    public void Break()
    {
        this.Speed = 0;
        Console.WriteLine("Car stopped!");
    }

    private void Rent()
    {
        this.rentCount++;
        Console.WriteLine($"Rent count : {this.rentCount}");
    }

    private void Older()
    {
        int oldAge = age;
        oldAge++;
        age = oldAge;
        Console.WriteLine($"Car's new Age : {age}");
    }
    
    
}