namespace Task5;

public class SmartPhone : Mobile
{   
    public Camera Camera { get; set; }
    public string Os { get; set; }
    
    public SmartPhone(string moNumber, int moCharger, int moDisplaySize, string os) : base(moNumber, moCharger, moDisplaySize)
    {
        Camera = new Camera(moDisplaySize);
        Os = os;
    }

    public override void Call(String number)
    {
        callHistory.Add(number);
        Console.WriteLine("Number: " + base.Number + " is called " + number + ".");
    }

    public override void GetCallHistory()
    {   
        Console.WriteLine("Call History:");
        /*foreach (var num in callHistory)
        {
            Console.WriteLine(num);
        }*/

        for (int i = callHistory.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(callHistory[i]);
        }
    }

    public override void WriteMessage(String number, String message)
    {
        if (messageHistory.ContainsKey(number))
        {
            messageHistory[number].Add(message);
        }
        else
        {
            messageHistory.Add(number, new (){message});
        }
        
        // messageHistory.ContainsKey(number) ? messageHistory[number].Add(message) : messageHistory.Add(number, new (){message});
        
        Console.WriteLine("Message has been sent.");
    }

    public override void GetMessageHistory()
    {   
        Console.WriteLine("Message History:");
        foreach (var num in messageHistory.Keys)
        {
            Console.WriteLine(num + ":");
            for (int i = 0; i < messageHistory[num].Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + messageHistory[num][i]);
            }
        }
    }

    public override string GetCurrentTimeAndData()
    {
        return DateTime.Now.ToString("HH:mm:ss") +
               "\n" + DateTime.Now.ToString("dd MMMM yyyy");
    }

    public override void TurnOnOrOffFlashlight()
    {
        /*if (Flashlight == false)
        {
            Flashlight = true;
            Console.WriteLine("Flashlight is turn on.");
        }
        else
        {
            Flashlight = false;
            Console.WriteLine("Flashlight is turn off."); // в одну строку
        }*/

        string currStr = "Flashlight is turn ";

        Console.WriteLine(Flashlight ? currStr + "off." : currStr + "on.");
    }

    public void TakePhoto()
    {
        Camera.TakePhoto();
    }

    public String GetLastPhoto()
    {
        return Camera.GetLastPhoto();
    }
}