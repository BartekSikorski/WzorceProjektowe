namespace WzorceProjektowe.Creational.Builder
{
    public abstract class BaseVehicleBuilder : IBuilder<Vehicle>
    {
        protected Vehicle _vehicle;

        public BaseVehicleBuilder() : this(new Vehicle())
        {
        }

        protected BaseVehicleBuilder(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)_vehicle.Clone();
        }
    }
}