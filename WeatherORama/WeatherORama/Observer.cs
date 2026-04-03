using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherORama
{
    public class SmallTv : IObserver, IDisplayElement
    {
        public float temperature;
        public float humidity;
        public float pressure;
        public ISubject weatherData;

        public SmallTv(ISubject wd)
        {
            this.weatherData = wd;
            wd.RegisterObserver(this);
        }

        public void Update(float temp, float hum, float pres)
        {
            this.temperature = temp;
            this.humidity = hum;
            this.pressure = pres;
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine("Data in small TV : \nTemperature = {0}, Humidity = {1} and Pressure = {2}", temperature, humidity, pressure);
        }

        public void UnSubscribe()
        {
            weatherData.RemoveObserver(this);
        }
    }
}
