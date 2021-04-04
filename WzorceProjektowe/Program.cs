using System;
using WzorceProjektowe.Strukturalne.Adapter.I;

namespace WzorceProjektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Strukturalne.Bridge.II.Client.Execute();
        }
    }
}
