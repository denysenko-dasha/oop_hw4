namespace WorkApp;
public class Manager : Worker
{
    private readonly Random rand = new Random();
    public Manager(string name): base(name)
    {
        Position = "Менеджер";
    }

    public override void FillWorkDay()
    {
        int callsFirst = rand.Next(1, 11);
        for (int i = 0; i < callsFirst; i++)
        {
            Call();
        }
        Relax();
        int callsSecond = rand.Next(1, 6);
        for (int i = 0; i < callsSecond; i++)
        {
            Call();
        }
    }
}