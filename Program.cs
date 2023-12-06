
class Program
{
    static void Main(string[] args)
    {
        Car audiCar = new Car("blue", 280, "Audi");
        Car ferrariCar = new Car("red", 260, "Ferrari");
        Console.WriteLine("You car is: " + audiCar.Model);
        Console.WriteLine("You car is: " + ferrariCar.Model);

    }
}
