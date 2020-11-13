using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Android android = new Android();
            IPhone iphone = new IPhone();

            LightningToMicroUsbAdapter adapter = new LightningToMicroUsbAdapter(iphone);

            RechargeMicroUsbPhone(android);
            Console.WriteLine();
            RechargeLightningPhone(iphone);
            Console.WriteLine();
            RechargeMicroUsbPhone(adapter);

            Console.ReadKey();
        }

        static void RechargeMicroUsbPhone(IMicroUsbPhone microUsbPhone)
        {
            microUsbPhone.UseMicroUSB();
            microUsbPhone.Recharge();
        }

        static void RechargeLightningPhone(ILightningPhone lightningPhone)
        {
            lightningPhone.UseLightning();
            lightningPhone.Recharge();
        }
    }
}
