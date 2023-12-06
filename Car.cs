
class Car
{
    private string color = "red";
    private int maxSpeed = 180;
    private int seats;
    private string type = 'gas';
    public string Model
    {
        get; set;
    }

    public Car(string color, int maxSpeed, string model)
    {
        this.color = color;
        this.maxSpeed = maxSpeed;
        this.Model = model;
    }
}