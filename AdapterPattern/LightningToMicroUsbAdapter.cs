using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class LightningToMicroUsbAdapter : IMicroUsbPhone
    {
        ILightningPhone lightningPhone;

        public LightningToMicroUsbAdapter(ILightningPhone lightningPhone)
        {
            this.lightningPhone = lightningPhone;
        }

        public void Recharge()
        {
            lightningPhone.Recharge();
        }

        public void UseMicroUSB()
        {
            Console.WriteLine("MicroUSB Connected");
            lightningPhone.UseLightning();
        }
    }
}
