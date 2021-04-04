using System;

namespace WzorceProjektowe.Strukturalne.Bridge.II
{
    public class Client
    {
        public static void Execute()
        {
            var messageSms = new MessageAbstraction(new SmsGate());
            messageSms.Send(Console.ReadLine());

            var messageMail = new MessageAbstraction(new MailGate());
            messageMail.Send(Console.ReadLine());

            var shortM = new ShortMessageAbstraction(new SmsGate());
            shortM.Send(Console.ReadLine());

            var shortMailM = new ShortMessageAbstraction(new MailGate());
            shortMailM.Send(Console.ReadLine());

        }
    }
}