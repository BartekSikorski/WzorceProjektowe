using System;
using System.Linq;

namespace WzorceProjektowe.Strukturalne.Bridge.II
{
    public class SmsGate : IMessageImplementation
    {
        public const int MaxLength = 10;

        public void SendMesssage(string message)
        {
            var aaa = Enumerable.Range(0, message.Length / MaxLength + 1);
            var splitedMessage = Enumerable.Range(0, message.Length / MaxLength)
                .Select(x => message.Substring(x * MaxLength, MaxLength));

            var splited2 = Chop(message, MaxLength);
            var i = 0;
            foreach (var m in splited2)
            {
                Console.WriteLine($"Wysłano wiadomość sms {i++}: {m}");
            }
        }

        private static string[] Chop(string value, int length)
        {
            int strLength = value.Length;
            int strCount = (strLength + length - 1) / length;
            string[] result = new string[strCount];
            for (int i = 0; i < strCount; ++i)
            {
                result[i] = value.Substring(i * length, Math.Min(length, strLength));
                strLength -= length;
            }
            return result;
        }
    }
}