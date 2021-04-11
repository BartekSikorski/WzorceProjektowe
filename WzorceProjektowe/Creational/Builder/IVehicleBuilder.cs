namespace WzorceProjektowe.Creational.Builder
{
    public interface IVehicleBuilder<T>
    {
        IVehicleBuilder<T> SetWheels(int value);

        IVehicleBuilder<T> SetSeats(int value);

        IVehicleBuilder<T> SetDoors(int value);

        IVehicleBuilder<T> SetTrunkCapacity(int value);

        IVehicleBuilder<T> SetEnginePower(int value);

        T Build();
    }
}