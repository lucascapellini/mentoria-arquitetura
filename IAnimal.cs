interface IAnimal
{
    void run();
    void animalSound();
}

class Horse : IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("neighhh");
    }

    public void run()
    {
        Console.WriteLine("Horse is running");
    }
}

