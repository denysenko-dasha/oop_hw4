namespace Shop;

public class Good
{
    public double Price { get; private set; }
    public string Country { get; private set; }
    public string Date { get; private set; }
    public string Name { get; set; }
    public string Description { get; private set; }

    public Good(double price, string country, string date, string name, string description)
    {
        Price = price;
        Country = country;
        Date = date;
        Name = name;
        Description = description;
    }

    
}