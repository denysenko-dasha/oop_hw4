namespace WorkApp;
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type team name: ");
        string teamName = Console.ReadLine() ?? "No team name";
        Team team = new Team(teamName);
        string answer = "";

        while (answer != "0")
        {
            Console.WriteLine("Choose your action:");
            Console.WriteLine("0 - exit");
            Console.WriteLine("1 - add developer");
            Console.WriteLine("2 - add manager");
            Console.WriteLine("3 - show team info");
            Console.WriteLine("4 - show full team info");

            Console.Write("Write your answer (0, 1, 2, 3, 4): ");

            answer = Console.ReadLine() ?? "0";

            if (answer == "0")
            {
                Console.WriteLine("You exited");
            }
            else if (answer == "1")
            {
                Console.Write("Enter developer's name: ");
                string developerName = Console.ReadLine() ?? "No name";
                Developer developer = new Developer(developerName);
                developer.FillWorkDay();
                team.AddWorker(developer);
                Console.WriteLine($"You added developer {developerName} to the team {teamName}");
            }
            else if (answer == "2")
            {
                Console.Write("Enter manager's name: ");
                string managerName = Console.ReadLine() ?? "No name";
                Manager manager = new Manager(managerName);
                manager.FillWorkDay();
                team.AddWorker(manager);
                Console.WriteLine($"You added manager {managerName} to the team {teamName}");
            }
            else if (answer == "3")
            {
                team.GetInfo();
            }
            else if (answer == "4")
            {
                team.GetFullInfo();
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}