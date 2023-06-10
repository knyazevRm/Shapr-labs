using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libSmart
{
    internal class SmartIntercom : SiemensMobile
    {
        public int Volume { get; set; }
        public bool IsMuted { get; set; }

        public SmartIntercom(string model) : base(model)
        {
            Volume = 50;
            IsMuted = false;
        }

        public void AdjustVolume(int amount)
        {
            Volume += amount;
            if (Volume > 100)
            {
                Volume = 100;
            }
            else if (Volume < 0)
            {
                Volume = 0;
            }
        }

        public void Mute()
        {
            IsMuted = true;
        }

        public void Unmute()
        {
            IsMuted = false;
        }
    }
}
