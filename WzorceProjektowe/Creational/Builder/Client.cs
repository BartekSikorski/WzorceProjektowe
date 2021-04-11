using Newtonsoft.Json;
using System;

namespace WzorceProjektowe.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            var vehicle = new VehicleBuilder()
                 .SetDoors(4)
                 .SetEnginePower(1500)
                 .SetSeats(4)
                 .SetWheels(4)
                 .Build();

            Console.WriteLine(JsonConvert.SerializeObject(vehicle));

        }
    }
}