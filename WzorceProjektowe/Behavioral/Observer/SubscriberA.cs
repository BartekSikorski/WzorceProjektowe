using System;
using System.Threading;

namespace WzorceProjektowe.Behavioral.Observer
{
    public class SubscriberA : Subscriber
    {
        public override void OnNext(int value)
        {
            Thread.Sleep(10000);
            if (value < 5)
                Console.WriteLine($"{GetType().Name}: reaguje na zmianę");
        }
    }
}