using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libSmart
{
    internal class SmartPhone : SiemensMobile
    {
        public string PhoneNumber { get; set; }
        public bool IsConnectedToInternet { get; set; }

        public SmartPhone(string model, string phoneNumber) : base(model)
        {
            PhoneNumber = phoneNumber;
            IsConnectedToInternet = false;
        }

        public void ConnectToInternet()
        {
            IsConnectedToInternet = true;
        }

        public void DisconnectFromInternet()
        {
            IsConnectedToInternet = false;
        }

        public string MakeCall(string number)
        {
            if (IsOn && BatteryLevel > 0)
            {
                UseBattery(10);
                return $"Calling {number} from {PhoneNumber}";
            }
            else
            {
                return "Phone is not turned on or battery is too low";
            }
        }

        public string SendText(string number, string message)
        {
            if (IsOn && BatteryLevel > 0)
            {
                UseBattery(5);
                return $"Sending text message '{message}' to {number} from {PhoneNumber}";
            }
            else
            {
                return "Phone is not turned on or battery is too low";
            }
        }
    }
}
