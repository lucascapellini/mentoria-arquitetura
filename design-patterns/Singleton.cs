class IOManager {
    private static IOManager instance;

    private bool receivedInput;
    private bool deviceActive;
    private void printSomething(string something) {
        Console.WriteLine(something);
    }

    private IOManager() {
        this.deviceActive = true;
    }

    public static IOManager getInstance() {
        if(IOManager.instance == null) {
            IOManager.instance = new IOManager();
        } 
        return IOManager.instance;
    }
}