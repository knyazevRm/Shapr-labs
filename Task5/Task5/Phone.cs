namespace Task5;

public interface Phone
{
    public string Number { get; set; }

    public void Call(string number);

    public void GetCallHistory();

    public void WriteMessage(String number, String message);

    public void GetMessageHistory();
}