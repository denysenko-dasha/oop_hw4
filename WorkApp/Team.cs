namespace WorkApp;
public class Team
{
    public string Name { get; set; }
    private List<Worker> workers = new List<Worker>();
    public Team(string name)
    {
        Name = name;
    }

    public void AddWorker(Worker worker)
    {
        workers.Add(worker);
    }

    public void GetInfo()
    {
        Console.WriteLine("Team name: " + Name);
        foreach (var worker in workers)
        {
            Console.WriteLine(worker.Name);
        }
    }

    public void GetFullInfo()
    {
        Console.WriteLine("Team name: " + Name);
        foreach (var worker in workers)
        {
            Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay}");
        }
    }
}