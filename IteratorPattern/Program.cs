using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationBar notificationBar = new NotificationBar(new NotificationCollection());

            notificationBar.PrintNotifications();

            Console.ReadKey();
        }
    }
}
