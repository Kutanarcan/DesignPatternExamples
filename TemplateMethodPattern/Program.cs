using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessTemplate onlineOrder = new OnlineOrder();
            OrderProcessTemplate storeOrder = new StoreOrder();

            onlineOrder.ProcessOrders(true);
            Console.WriteLine();
            storeOrder.ProcessOrders(false);

            Console.ReadKey();
        }
    }
}
