namespace WzorceProjektowe.Creational.FactoryMethod
{
    public class Elevator
    {
        internal void Execute(string action, int flour)
        {
            CreateOperation(action).Operate(flour);
        }

        public IElevatorOperation CreateOperation(string action)
        {
            switch (nameof(Elevator) + action)
            {
                case nameof(ElevatorDown):
                    return new ElevatorDown();

                case nameof(ElevatorUp):
                    return new ElevatorUp();
            }
            return null;
        }
    }
}