
class Car
{
    protected int maxSpeed = 180;
    private int seats;
    public string Model
    {
        get; set;
    }

    public Car(int maxSpeed, string model, int seats)
    {
        this.maxSpeed = maxSpeed;
        this.Model = model;
        this.seats = seats;
    }

    public virtual void start()
    {
        Console.WriteLine(this.Model + " Car ready to go");
    }
}

class SportsCar : Car
{
    public int year;
    public string Power
    {
        get; set;
    }

    public SportsCar(int year, int maxSpeed, string model, string power) : base(maxSpeed, model, 2)
    {
        this.Power = power;
        this.year = year;
        this.maxSpeed = maxSpeed;
        this.Model = model;
    }

    public override void start()
    {
        Console.WriteLine(this.Model + " Sports Car ready to run");
    }
}

class EletricCar : Car
{

    public EletricCar(int maxSpeed, string model) : base(maxSpeed, model, 2)
    {
        this.maxSpeed = maxSpeed;
        this.Model = model;
    }
    public override void start()
    {
        Console.WriteLine(this.Model + " Eletric Car ready to go");
    }
}