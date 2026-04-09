using System;
using System.Collections.Generic;
using System.Text;

namespace ObservePattern
{
    public interface ISubject
    {
        void AddObserver(IObserver _);
        void RemoveObserver(IObserver _);
        void NotifyObserver();

    }
}
