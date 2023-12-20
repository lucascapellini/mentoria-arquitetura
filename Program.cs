
class Program
{
    static void Main(string[] args)
    {
        Device smartphone = new Smartphone();
        Device notebook = new Notebook();

        smartphone.createScreen();
        smartphone.userEvent();

        notebook.createScreen();
        notebook.userEvent();
    }
}
