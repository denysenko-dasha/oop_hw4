namespace GeographicInterface;

public class Mountain : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPeak { get; private set; }
    

    public Mountain(double xCoord, double yCoord, string name, string description, double peak)
    {
        X = xCoord;
        Y = yCoord;
        Name = name;
        Description = description;
        HighestPeak = peak;
        
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name of the object: {Name}, description: {Description}");
        Console.WriteLine($"(x, y): {X}, {Y}");
        Console.WriteLine($"Highest peak of the mountain: {HighestPeak}");
    }


}