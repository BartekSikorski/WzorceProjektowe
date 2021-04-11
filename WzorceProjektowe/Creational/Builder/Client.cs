using Newtonsoft.Json;
using System;

namespace WzorceProjektowe.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            var vehicle = new VehicleBuilderFacade()
                .Components
                    .SetDoors(4)
                    .SetEnginePower(1500)
                    .SetSeats(4)
                    .SetWheels(4)
                 .Manufacturer
                    .SetManufacturer("BArtek SA")
                    .SetModel("Traktor GT TD")
                    .SetProductionDate(DateTime.Today)
                 .Build();

            Console.WriteLine(JsonConvert.SerializeObject(vehicle));
        }
    }
}