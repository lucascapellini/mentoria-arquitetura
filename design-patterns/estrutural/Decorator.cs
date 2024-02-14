class User
{
    private string token;

    public User(string token)
    {
        this.token = token;
    }

    public string getUserToken()
    {
        return this.token;
    }
}

abstract class Screen
{

    public User user;

    public abstract void showGUI();
}

class DesktopScreen : Screen
{
    private string gui;
    public override void showGUI()
    {
        Console.WriteLine(gui);
    }
}

abstract class ScreenDecorator : Screen
{
    public Screen screen;

    public ScreenDecorator(Screen screen)
    {
        this.screen = screen;
    }

    public override void showGUI()
    {
        Console.WriteLine(screen.showGUI);
    }
}

class UserSessionDecorator : ScreenDecorator
{
    public UserSessionDecorator(Screen screen) : base(screen)
    {
        this.screen = screen;
    }

    public override void showGUI()
    {
        if (bool.Parse(this.screen.user.getUserToken()))
        {
            this.screen.showGUI();
        }
        else
        {
            Console.WriteLine("Error 401: Unauthorized");
        }
    }
}