using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class OrderProcessTemplate
    {
        protected abstract void SelectItem();
        protected abstract void Payment();

        protected void GiftWrap()
        {
            Console.WriteLine("Item Wrapped.");
        }

        protected abstract void Delivery();

        public void ProcessOrders(bool isGift) 
        {
            SelectItem();
            Payment();
            if (isGift) GiftWrap();
            Delivery();
        }
    }
}
