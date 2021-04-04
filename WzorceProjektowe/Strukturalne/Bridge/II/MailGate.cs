using System;

namespace WzorceProjektowe.Strukturalne.Bridge.II
{
    public class MailGate : IMessageImplementation
    {
        public void SendMesssage(string message)
        {
            Console.WriteLine($"Wysłano wiadomość email: {message}.");
        }
    }
}