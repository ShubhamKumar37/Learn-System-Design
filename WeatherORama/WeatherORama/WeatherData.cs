using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherORama
{
    public class WeatherData : ISubject, IObserver
    {
        public float temperature;
        public float humidity;
        public float pressure;
        public List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver ob)
        {
            Console.WriteLine(ob.ToString());
            observers.Add(ob);
        }

        public void RemoveObserver(IObserver ob)
        {
            observers.Remove(ob);
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Observers getting notified about new data {0}", observers.Count);
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver ob = observers.ElementAt(i);
                if(ob != null) ob.Update(temperature, humidity, pressure);
            }
        }

        public void Update(float temp, float hum, float pres)
        {
            this.temperature = temp;
            this.pressure = pres;
            this.humidity = hum;

            NotifyObservers();
        }
    }
}
