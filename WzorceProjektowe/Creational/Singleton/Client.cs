using System;

namespace WzorceProjektowe.Creational.Singleton
{
    public class Client
    {
        public static void Execute()
        {
            var service1 = Context.Instance.GetSettings("1");
            Console.WriteLine($"Service: {service1}");

            var service2 = Context.Instance.GetSettings("2");
            Console.WriteLine($"Service: {service2}");

            Context.Instance.SetSettings("2", "X");
            service2 = Context.Instance.GetSettings("2");
            Console.WriteLine($"Service: {service2}");
        }
    }
}