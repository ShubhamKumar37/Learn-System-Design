using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherORama
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
