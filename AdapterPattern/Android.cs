using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Android :IMicroUsbPhone
    {
        public void Recharge()
        {
            Console.WriteLine("MicroUSB Charge Started.");
        }

        public void UseMicroUSB()
        {
            Console.WriteLine("MicroUSB Connected.");
        }
    }
}
