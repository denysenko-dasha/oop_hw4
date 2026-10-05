namespace Shop;

public class Product : Good
{
    public string ExpirationDate { get; private set; }
    public int Quantity { get; private set; }
    public string Unit { get; private set; }

    public Product(double price, string country, string date, string name, string description, string expire, int quantity, string unit)
        : base(price, country, date, name, description)
    {
        ExpirationDate = expire;
        Quantity = quantity;
        Unit = unit;
    }

    
}