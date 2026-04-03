using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherORama
{
    public interface ISubject
    {
        void RegisterObserver(IObserver ob);
        void RemoveObserver(IObserver ob);
        void NotifyObservers();
    }
}
