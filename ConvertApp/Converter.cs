namespace ConvertApp;
public class Converter
{
    public decimal DollarRate { get; private set; }
    public decimal EuroRate { get; private set; }
    public Converter(decimal dollarRate, decimal euroRate)
    {
        DollarRate = dollarRate;
        EuroRate = euroRate;
    }
    

    public decimal ConvertUahToUsd(decimal uahMoney)
    {
        if (uahMoney <= 0)
        {
            return 0;
        }

        return uahMoney / DollarRate;
    }

    public decimal ConvertUahToEuro(decimal uahMoney)
    {
        if (uahMoney <= 0)
        {
            return 0;
        }

        return uahMoney / EuroRate;
    }
    
    public decimal ConvertUsdToUah(decimal usdMoney)
    {
        return usdMoney * DollarRate;
    }

    public decimal ConvertEuroToUah(decimal euroMoney)
    {
        return euroMoney * EuroRate;
    }
}