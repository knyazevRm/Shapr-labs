namespace Task5;

public class SmartIntercom : Mobile
{
    public SmartIntercom(string moNumber, int moCharger, int moDisplaySize) : base(moNumber, moCharger, moDisplaySize)
    {
    }

    public override void Call(string number)
    {
        throw new NotImplementedException();
    }

    public override void GetCallHistory()
    {
        throw new NotImplementedException();
    }

    public override void WriteMessage(string number, string message)
    {
        throw new NotImplementedException();
    }

    public override void GetMessageHistory()
    {
        throw new NotImplementedException();
    }

    public override string GetCurrentTimeAndData()
    {
        throw new NotImplementedException();
    }

    public override void TurnOnOrOffFlashlight()
    {
        throw new NotImplementedException();
    }
}