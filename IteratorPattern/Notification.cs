using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class Notification
    {
        string notificationMessage;
        public string NotificationMessage => notificationMessage;

        public Notification(string notification)
        {
            this.notificationMessage = notification;
        }
    }
}
