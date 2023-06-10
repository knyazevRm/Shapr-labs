namespace ConsoleApplication;

internal class Book
{
    private string title;
    private int numOfPages;
    private int price;

    public string Title
    {
        get => title;
        set => title = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int NumOfPages
    {
        get => numOfPages;
        set => numOfPages = value;
    }

    public int Price
    {
        get => price;
        set => price = value;
    }

    public virtual double GetQuality()
    {
        return 1.0 * Price / NumOfPages ;
    }

    public override string ToString()
    {
        return $"Book: Title = {Title}, Number of pages = {NumOfPages}, Price = {Price}, Q = {GetQuality()}";
    }

    public Book(string title, int numOfPages, int price)
    {
        if (numOfPages <= 0 || title is null || price < 0)
        {
            throw new ArgumentException();
        }

        if (title == "")
        {
            title = "Unknown";
        }
        this.title = title;
        this.numOfPages = numOfPages;
        this.price = price;
    }
}