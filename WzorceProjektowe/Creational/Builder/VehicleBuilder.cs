namespace WzorceProjektowe.Creational.Builder
{
    public class VehicleBuilder : BaseVehicleBuilder
    {
        public VehicleBuilder SetDoors(int value)
        {
            _vehicle.Doors = value;
            return this;
        }

        public VehicleBuilder SetEnginePower(int value)
        {
            _vehicle.EnginePower = value;
            return this;
        }

        public VehicleBuilder SetSeats(int value)
        {
            _vehicle.Seats = value;
            return this;
        }

        public VehicleBuilder SetTrunkCapacity(int value)
        {
            _vehicle.TrunkCapacity = value;
            return this;
        }

        public VehicleBuilder SetWheels(int value)
        {
            _vehicle.Wheels = value;
            return this;
        }
    }
}