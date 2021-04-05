using System;

namespace WzorceProjektowe.Strukturalne.Docorator.I
{
    public class Notification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Wysłano wiadomość: {message}");
        }
    }
}