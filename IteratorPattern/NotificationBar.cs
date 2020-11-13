using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class NotificationBar
    {
        NotificationCollection notificationCollection;

        public NotificationBar(NotificationCollection notificationCollection)
        {
            this.notificationCollection = notificationCollection;
        }

        public void PrintNotifications()
        {
            Iterator iterator = notificationCollection.CreateIterator();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("....NOTIFICATION BAR....");

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            while (iterator.HasNext())
            {
                Notification noti = iterator.Next();
                Console.WriteLine(noti.NotificationMessage);
            }
        }
    }
}
