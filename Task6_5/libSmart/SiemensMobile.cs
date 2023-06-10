using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libSmart
{
    internal abstract class SiemensMobile : Mobile
    {
        public string Model { get; set; }
        public int BatteryLevel { get; set; }
        public bool IsOn { get; set; }

        public SiemensMobile(string model)
        {
            Model = model;
            BatteryLevel = 100;
            IsOn = false;
        }

        public virtual void ChargeBattery(int amount)
        {
            BatteryLevel += amount;
            if (BatteryLevel > 100)
            {
                BatteryLevel = 100;
            }
        }

        public virtual void UseBattery(int amount)
        {
            BatteryLevel -= amount;
            if (BatteryLevel < 0)
            {
                BatteryLevel = 0;
                IsOn = false;
            }
        }

        public void TurnOn()
        {
            IsOn = true;
        }

        public void TurnOff()
        {
            IsOn = false;
        }
    }
}
