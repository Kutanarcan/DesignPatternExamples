using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class NotificationCollection : Collection
    {
        const int MAX_ITEMS = 6;
        int numberOfItems = 0;
        Notification[] notifications;

        public NotificationCollection()
        {
            notifications = new Notification[MAX_ITEMS];
            //Test
            AddItem("     Notification-1");
            AddItem("     Notification-2");
            AddItem("     Notification-3");
            AddItem("     Notification-4");
            AddItem("     Notification-5");
            AddItem("     Notification-6");
            //Test
        }

        public void AddItem(string message)
        {
            Notification not = new Notification(message);

            if (numberOfItems >= MAX_ITEMS)
                Console.WriteLine("Collection Full");
            else
            {
                notifications[numberOfItems] = not;
                numberOfItems++;
            }
        }

        public Iterator CreateIterator()
        {
            return new NotificationIterator(notifications);
        }
    }
}
