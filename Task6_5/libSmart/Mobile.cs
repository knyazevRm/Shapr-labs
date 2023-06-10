using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libSmart
{
    internal interface Mobile
    {
        string Model { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
