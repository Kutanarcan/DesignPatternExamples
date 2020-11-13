namespace IteratorPattern
{
    public class NotificationIterator : Iterator
    {
        private Notification[] notifications;
        int pos = 0;

        public NotificationIterator(Notification[] notifications)
        {
            this.notifications = notifications;
        }

        public bool HasNext()
        {
            bool result = (pos >= notifications.Length || notifications[pos] == null) ? false : true;

            return result;
        }

        public Notification Next()
        {
            Notification noti = notifications[pos];
            pos++;

            return noti;
        }
    }
}