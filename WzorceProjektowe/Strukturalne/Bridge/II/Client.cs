using System;

namespace WzorceProjektowe.Strukturalne.Bridge.II
{
    public class Client
    {
        public static void Execute()
        {
            var message = new MessageAbstraction(new SmsGate());
            message.Send(Console.ReadLine());
            
        }
    }
}