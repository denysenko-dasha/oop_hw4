namespace Shop;

public class Book : Good
{
    public int PagesCount { get; private set; }
    public string Publisher { get; private set; }
    public List<string> Authors { get; private set; }

    public Book(double price, string country, string date, string name, string description, int pages, string publisher, List<string> authors)
        : base(price, country, date, name, description)
    {
        PagesCount = pages;
        Publisher = publisher;
        Authors = authors;
    }

    
}