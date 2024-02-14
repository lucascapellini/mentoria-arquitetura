interface IScreen
{
    void onUserInteraction();
}

class NormalScreen : IScreen
{

    public void onUserInteraction()
    {
        Console.WriteLine("User click");
    }
}

class TouchScreen : IScreen
{
    public void onUserInteraction()
    {
        Console.WriteLine("User touch");
    }
}

abstract class Device // Factory Essa classe deve ser abstrata?
{
    protected IScreen screen;
    public abstract IScreen createScreen();

    public virtual void userEvent()
    {
        Console.WriteLine("Default userEvent handler");
    }
}

class Smartphone : Device
{
    public override IScreen createScreen()
    {
        Console.WriteLine("Created Smartphone device");
        this.screen = new TouchScreen();
        return this.screen;
    }

    public override void userEvent()
    {
        this.screen.onUserInteraction();
    }
}

class Notebook : Device
{
    public override IScreen createScreen()
    {
        Console.WriteLine("Created Notebook device");
        this.screen = new NormalScreen();
        return this.screen;
    }

    public override void userEvent()
    {
        this.screen.onUserInteraction();
    }
}