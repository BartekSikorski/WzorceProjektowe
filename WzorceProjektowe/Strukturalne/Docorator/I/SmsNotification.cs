using System;

namespace WzorceProjektowe.Strukturalne.Docorator.I
{
    public class SmsNotification : NotificationBaseDecorator
    {
        public SmsNotification(INotification notification) : base(notification)
        {
        }

        public override void SendExtra(string message)
        {
            Console.WriteLine($"Wysłano wiadomośSMS: {message}");
        }
    }
}