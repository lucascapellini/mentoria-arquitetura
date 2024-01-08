// computer cellphone tablet
// apple -> imac iphone ipad
// samsumg -> 

interface Computer
{
    void hasPhysicalKeyboard();
}

class Imac : Computer
{
    public void hasPhysicalKeyboard()
    {
        Console.WriteLine("magic keyboard");
    }
}

class Book : Computer
{
    public void hasPhysicalKeyboard()
    {
        Console.WriteLine("samsumg book keyboard");
    }
}

interface Cellphone
{
    void hasCameras();
    void isSmall();
    void hasTouchscreen();
}

class Iphone : Cellphone
{
    public void hasCameras()
    {
        Console.WriteLine("has 3 cameras");
    }
    public void isSmall()
    {
        Console.WriteLine("has a pocket size");
    }

    public void hasTouchscreen()
    {
        Console.WriteLine("it is touch!");
    }
}

class Galaxy : Cellphone
{
    public void hasCameras()
    {
        Console.WriteLine("has 5 cameras");
    }
    public void isSmall()
    {
        Console.WriteLine("it is small but also almost a tablet");
    }

    public void hasTouchscreen()
    {
        Console.WriteLine("it is touch!");
    }
}

interface Tablet
{
    void hasCameras();
    void isLarge();
    void hasTouchscreen();
}

class Ipad : Tablet
{
    public void hasCameras()
    {
        Console.WriteLine("has 2 cameras and a good selfie camera");
    }
    public void isLarge()
    {
        Console.WriteLine("it is thin like a notebook and light weight");
    }

    public void hasTouchscreen()
    {
        Console.WriteLine("it is touch!");
    }
}

class Tabs : Tablet
{
    public void hasCameras()
    {
        Console.WriteLine("has 2 cameras");
    }
    public void isLarge()
    {
        Console.WriteLine("it is like an notebook in you bag");
    }

    public void hasTouchscreen()
    {
        Console.WriteLine("it is touch!");
    }
}

interface DevicesFactory
{
    Computer createComputer();
    Cellphone createCellphone();
    Tablet createTablet();
}

class AppleFactory : DevicesFactory
{
    private Computer imac;
    private Cellphone iphone;
    private Tablet ipad;

    public Computer createComputer()
    {
        return new Imac();
    }
    public Cellphone createCellphone()
    {
        return new Iphone();
    }
    public Tablet createTablet()
    {
        return new Ipad();
    }
}

class SamsumgFactory : DevicesFactory
{
    private Computer book;
    private Cellphone galaxyS;
    private Tablet tabS;
    public Computer createComputer()
    {
        return new Book();

    }
    public Cellphone createCellphone()
    {
        return new Galaxy();
    }
    public Tablet createTablet()
    {
        return new Tabs();
    }
}