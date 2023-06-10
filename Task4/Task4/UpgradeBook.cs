namespace ConsoleApplication;

class UpgradeBook : Book
{
    private int yearOfPublication;

    public int YearOfPublication
    {
        get => yearOfPublication;
        set => yearOfPublication = value;
    }

    public override double GetQuality()
    {
        int currentYear = DateTime.Now.Year;
        return base.GetQuality() - 0.2 * (currentYear - YearOfPublication);
    }

    public override string ToString()
    {
        return $"Upgrade Book: Title = {Title}, Number of pages = {NumOfPages}, Price = {Price}, Year of publication = {YearOfPublication}, Q = {GetQuality()}";
    }
    

    public UpgradeBook(string title, int numOfPages, int price, int yearOfPublication) : base(title, numOfPages, price)
    {
        if (yearOfPublication > DateTime.Now.Year)
        {
            throw new ArgumentException();
        }
            
        this.yearOfPublication = yearOfPublication;
    }
    
}