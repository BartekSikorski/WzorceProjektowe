using System;

namespace WzorceProjektowe.Strukturalne.Docorator.I
{
    public class Client
    {
        private static bool sendSMS;

        public static void Execute()
        {
            var message = Console.ReadLine();
            var notification = (INotification)new Notification();
            sendSMS = true;
            if (sendSMS)
            {
                notification = new SmsNotification(notification);
            }

            notification.Send(message);
        }
    }
}