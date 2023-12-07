
class Program
{
    static void Main(string[] args)
    {
        Car audiCar = new Car(maxSpeed: 280, model: "Audi", seats: 4);
        SportsCar ferrariCar = new SportsCar(2022, 380, "bmw", "12000hp");

        EletricCar eletricCar = new EletricCar(220, "Tesla");

        Console.WriteLine("You car is: " + audiCar.Model);
        Console.WriteLine("You car is: " + ferrariCar.Model + ferrariCar.year);
        Console.WriteLine("And it has " + ferrariCar.Power + " horse power");

        audiCar.start();
        ferrariCar.start();
        eletricCar.start();


        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.animalSound();
        cat.animalSound();

        IAnimal horse = new Horse();
        horse.animalSound();
    }
}
