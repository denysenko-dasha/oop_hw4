namespace ConvertApp;
public class Program
{
    private static void Main(string[] args)
    {
        decimal usdRate = 44.8m;
        decimal euroRate = 50.55m;
        Converter converter = new Converter(usdRate, euroRate);
        string answer = "";

        while (answer != "0")
        {
            Console.WriteLine("0 - exit");
            Console.WriteLine("1 - UAH to USD");
            Console.WriteLine("2 - UAH to EURO");
            Console.WriteLine("3 - USD to UAH");
            Console.WriteLine("4 - EURO to UAH");
            
            Console.Write("Choose your action: ");

            answer = Console.ReadLine() ?? "0";

            if (answer == "0")
            {
                Console.WriteLine("You exited");
            }
            else if (answer == "1")
            {
                Console.Write("Write amount of money in UAH: ");
                string money = Console.ReadLine() ?? "0";
                if (decimal.TryParse(money, out decimal moneyUah))
                {
                    decimal result = converter.ConvertUahToUsd(moneyUah);
                    Console.WriteLine($"{result} USD");
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            else if (answer == "2")
            {
                Console.Write("Write amount of money in UAH: ");
                string money = Console.ReadLine() ?? "0";
                
                if (decimal.TryParse(money, out decimal moneyUah))
                {
                    decimal result = converter.ConvertUahToEuro(moneyUah);
                    Console.WriteLine($"{result} euro");
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            else if (answer == "3")
            {
                Console.Write("Write amount of money in USD: ");
                string money = Console.ReadLine() ?? "0";

                if (decimal.TryParse(money, out decimal moneyUsd))
                {

                    decimal result = converter.ConvertUsdToUah(moneyUsd);
                    Console.WriteLine($"{result} UAH");
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            else if (answer == "4")
            {
                Console.Write("Write amount of money in EUR: ");
                string money = Console.ReadLine() ?? "0";

                if (decimal.TryParse(money, out decimal moneyEuro))
                {

                    decimal result = converter.ConvertEuroToUah(moneyEuro);
                    Console.WriteLine($"{result} UAH");
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}