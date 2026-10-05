namespace GeographicApp;

public class Program
{
    private static void Main(string[] args)
    {
        River river = new River(35.5, 35.5, "New river", "bla", 23, 123.5);
        Mountain mountain = new Mountain(45.5, 45.5, "New mountain", "bla", 1250.5);

        river.GetInfo();
        mountain.GetInfo();
    }
}