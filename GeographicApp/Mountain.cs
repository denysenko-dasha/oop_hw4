namespace GeographicApp;

public class Mountain : GeographicObject
{
    public double HighestPeak { get; private set; }

    public Mountain(double xCoord, double yCoord, string name, string description, double peak) : base(xCoord, yCoord, name, description)
    {
        HighestPeak = peak;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Highest peak of the mountain: {HighestPeak}");
    }
}