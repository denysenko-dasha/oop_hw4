namespace WorkApp;
public abstract class Worker
{
    public string Name { get; set; }
    public string Position { get; set; }
    public string WorkDay { get; set; }
    public Worker(string name)
    {
        Name = name;
        Position = "";
        WorkDay = "";
    }

    public void Call()
    {
        WorkDay += "Call ";
    }

    public void WriteCode()
    {
        WorkDay += "Write Code ";
    }

    public void Relax()
    {
        WorkDay += "Relax ";
    }

    public abstract void FillWorkDay();
}

