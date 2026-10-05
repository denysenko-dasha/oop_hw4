namespace GeographicApp;

public class River : GeographicObject
{
    public double Speed { get; private set; }
    public double Length { get; private set; }

    public River(double xCoord, double yCoord, string name, string description, double speed, double length) : base(xCoord, yCoord, name, description)
    {
        Speed = speed;
        Length = length;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Speed: {Speed} (cm/sec), Length: {Length}");
    }
}