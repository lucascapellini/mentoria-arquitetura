abstract class Animal
{
    public int legs;
    protected string eyes;
    public abstract void animalSound();
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("AUAU");
    }
}

class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("MIAU");
    }
}