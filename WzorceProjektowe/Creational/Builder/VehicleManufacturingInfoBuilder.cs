using System;

namespace WzorceProjektowe.Creational.Builder
{
    public class VehicleManufacturingInfoBuilder : VehicleBuilderFacade
    {
        public VehicleManufacturingInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleManufacturingInfoBuilder SetManufacturer(string value)
        {
            _vehicle.Manufacturer = value;
            return this;
        }

        public VehicleManufacturingInfoBuilder SetModel(string value)
        {
            _vehicle.Model = value;
            return this;
        }

        public VehicleManufacturingInfoBuilder SetProductionDate(DateTime value)
        {
            _vehicle.ProductionDate = value;
            return this;
        }
    }
}