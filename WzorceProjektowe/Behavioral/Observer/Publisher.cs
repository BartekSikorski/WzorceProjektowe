using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WzorceProjektowe.Behavioral.Observer
{
    internal class Publisher : IObservable<int>, IDisposable
    {
        private ICollection<IObserver<int>> _observers = new List<IObserver<int>>();
        private int index;
        public int Index
        {
            get => index;
            set
            {
                index = value;
                Notify();
            }
        }

        private void Notify()
        {
            Task.Run(() =>
            {
                if (Index < 0)
                    _observers.ToList().ForEach(x => x.OnError(new IndexOutOfRangeException(Index.ToString())));

                _observers.ToList().ForEach(x => x.OnNext(Index));
            });
        }

        public void Dispose()
        {
            _observers.ToList().ForEach(x => x.OnCompleted());
            _observers.Clear();
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return null;
        }

        public void Work()
        {
            Console.WriteLine($"{GetType().Name}: Wykonuję jakieś obliczenia");
            Thread.Sleep(1000);
            Index = new Random().Next(-1, 10);
            Console.WriteLine($"{GetType().Name}: Zmienił się mój stan na {Index}");
        }
    }
}