namespace ConsoleApplication;

public class Console
{
    private void PrintString(string str)
    {
        System.Console.WriteLine(str);
    }
    
    private string? ReadString()
    {
        return System.Console.ReadLine();
    }
    
    private void ExecCommand()
    {
        string? command = null;
        while (true)
        {
            PrintString("Create Book object - 'B'.");
            PrintString("Create Upgrade Book object - 'U'.");
            PrintString("Close application - 'exit'.");

            command = ReadString();

            switch (command)
            {
                case "B":
                    PrintString("Enter title: ");
                    string? title = ReadString();
                    
                    PrintString("Enter number of pages: ");
                    int.TryParse(ReadString(), out int numOfPages);
                    
                    PrintString("Enter price: ");
                    int.TryParse(ReadString(), out int price);
                    
                    PrintString(new Book(title, numOfPages, price).ToString());
                    
                    break;
                
                case "U":
                    PrintString("Enter title: ");
                    string? titleUp = ReadString();
                    
                    PrintString("Enter number of pages: ");
                    int.TryParse(ReadString(), out int numOfPagesUp);
                    
                    PrintString("Enter price: ");
                    int.TryParse(ReadString(), out int priceUp);
                    
                    PrintString("Enter year of publication: ");
                    int.TryParse(ReadString(), out int yearOfPublication);
                    
                    PrintString(new UpgradeBook(titleUp, numOfPagesUp, priceUp, yearOfPublication).ToString());
                    
                    break;
                
                case "exit":
                    PrintString("Application is closed.");
                    return;

                default:
                    PrintString("Command wasn't found.");
                    break;
            }
        }
    }
    
    
    public Console()
    {
        ExecCommand();
    }
}