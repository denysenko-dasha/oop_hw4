namespace GeographicInterface;

public class River : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Speed { get; private set; }
    public double Length { get; private set; }

    public River(double xCoord, double yCoord, string name, string description, double speed, double length)
    {
        X = xCoord;
        Y = yCoord;
        Name = name;
        Description = description;
        Speed = speed;
        Length = length;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name of the object: {Name}, description: {Description}");
        Console.WriteLine($"(x, y): {X}, {Y}");
        Console.WriteLine($"Speed: {Speed} (cm/sec), Length: {Length}");
    }


}