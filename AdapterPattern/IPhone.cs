using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class IPhone : ILightningPhone
    {
        public void Recharge()
        {
            Console.WriteLine("Lightning Charge Started.");
        }

        public void UseLightning()
        {
            Console.WriteLine("Lightning Connected.");
        }
    }
}
