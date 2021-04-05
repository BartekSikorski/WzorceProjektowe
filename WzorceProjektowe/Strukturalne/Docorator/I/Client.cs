using System;

namespace WzorceProjektowe.Strukturalne.Docorator.I
{
    public class Client
    {
        private static bool sendSMS;
        private static bool sendEmail;

        public static void Execute()
        {
            var message = Console.ReadLine();
            var notification = (INotification)new Notification();
            sendSMS = sendEmail = true;
            if (sendSMS)
            {
                notification = new SmsNotification(notification);
            }
            if (sendEmail)
            {
                notification = new EmailNotification(notification);

            }

            notification.Send(message);
        }
    }
}