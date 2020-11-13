using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class OnlineOrder : OrderProcessTemplate
    {
        protected override void Delivery()
        {
            Console.WriteLine("Ship the item through post to delivery address");
        }

        protected override void Payment()
        {
            Console.WriteLine("Online Payment through Netbanking, card or Paytm");
        }

        protected override void SelectItem()
        {
            Console.WriteLine("Item added to online shopping cart");
            Console.WriteLine("Get gift wrap preference");
            Console.WriteLine("Get delivery address.");
        }
    }
}
