using System;

namespace WzorceProjektowe.Behavioral.Observer
{
    public abstract class Subscriber : IObserver<int>
    {
        public void OnCompleted()
        {
            Console.WriteLine($"{GetType().Name}: Transmisja zakończona");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name}: Error: {error.Message}");
        }

        public abstract void OnNext(int value);
    }
}