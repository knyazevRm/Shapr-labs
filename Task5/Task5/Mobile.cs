namespace Task5;

public abstract class Mobile : Phone
{
    protected string number;
    protected bool Flashlight { get; set; }
    protected int Charger { get; set; }
    protected int DisplaySize { get; set; }
    protected List<String> callHistory = new ();
    protected Dictionary<String, List<String>> messageHistory = new();
    public string Number { get => number; set => number = value; }

    protected Mobile(string moNumber, int moCharger, int moDisplaySize)
    {
        number = moNumber;
        Charger = moCharger;
        DisplaySize = moDisplaySize;
        Flashlight = false;
    }

    public abstract void Call(string number);
    public abstract void GetCallHistory();

    public abstract void WriteMessage(string number, string message);
    public abstract void GetMessageHistory();

    public abstract string GetCurrentTimeAndData();
    public abstract void TurnOnOrOffFlashlight();
}