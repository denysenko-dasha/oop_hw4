namespace GeographicApp;

public abstract class GeographicObject
{
    public double X { get; private set; }
    public double Y { get; private set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public GeographicObject(double xCoord, double yCoord, string name, string description)
    {
        X = xCoord;
        Y = yCoord;
        Name = name;
        Description = description;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Name of the object: {Name}, description: {Description}");
        Console.WriteLine($"(x, y): {X}, {Y}");
    }
}