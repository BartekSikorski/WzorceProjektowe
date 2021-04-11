using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.Creational.Builder
{
    public class VehicleBuilderFacade : BaseVehicleBuilder
    {
        public VehicleBuilderFacade()
        {
        }

        public VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Components => new VehicleBuilder(_vehicle);

        public VehicleManufacturingInfoBuilder Manufacturer => new VehicleManufacturingInfoBuilder(_vehicle);

    }
}
