using Task5;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            SmartPhone phone = new SmartPhone("1234", 20, 5, "Android");
            phone.TurnOnOrOffFlashlight();
            phone.TurnOnOrOffFlashlight();
            Console.WriteLine(phone.GetCurrentTimeAndData());
            phone.TakePhoto();
            Console.WriteLine(phone.GetLastPhoto());
            phone.TakePhoto();
            Console.WriteLine(phone.GetLastPhoto());
            
            phone.Call("5678");
            phone.WriteMessage("56789", "kkk");
            
            phone.Call("90");
            phone.WriteMessage("56789", "kkk");
            phone.WriteMessage("90", "k-k");
            
            phone.GetCallHistory();
            phone.GetMessageHistory();
        }
    }
}