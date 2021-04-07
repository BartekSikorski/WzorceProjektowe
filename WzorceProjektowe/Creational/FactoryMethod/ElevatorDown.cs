using System;

namespace WzorceProjektowe.Creational.FactoryMethod
{
    public class ElevatorUp : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Winda zatrzyma się na piętrze {floor} podczas jazdy w górę");
        }
    }
}