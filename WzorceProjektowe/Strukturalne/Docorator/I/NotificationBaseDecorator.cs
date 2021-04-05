using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.Strukturalne.Docorator.I
{
    public abstract class NotificationBaseDecorator : INotification
    {
        public NotificationBaseDecorator(INotification notification)
        {
            Notification = notification;
        }

        public INotification Notification { get; }

        public void Send(string message)
        {
            Notification.Send(message);
            SendExtra(message);
        }

        public abstract void SendExtra(string message);
    }
}
