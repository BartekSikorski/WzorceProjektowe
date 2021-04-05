using System;

namespace WzorceProjektowe.Strukturalne.Docorator.I
{
    public class EmailNotification : NotificationBaseDecorator
    {
        public EmailNotification(INotification notification) : base(notification)
        {
        }

        public override void SendExtra(string message)
        {
            Console.WriteLine($"Wysłano E-mail: {message}.");
        }
    }
}