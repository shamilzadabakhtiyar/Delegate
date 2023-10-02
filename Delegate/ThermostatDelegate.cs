using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void TemperatureChangedHandler(double newTemperature);

    public class ThermostatDelegate
    {
        TemperatureChangedHandler temperatureChangedDelegate;

        private double temperature;
        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (value != temperature)
                {
                    temperature = value;
                    OnTemperatureChanged(temperature);
                }
            }
        }
        void OnTemperatureChanged(double newTemperature)
        {
            temperatureChangedDelegate?.Invoke(newTemperature);
        }
        public void AddTemperatureChangedHandler(TemperatureChangedHandler handler)
        {
            temperatureChangedDelegate += handler;
        }

        public void RemoveTemperatureChangedHandler(TemperatureChangedHandler handler)
        {
            temperatureChangedDelegate -= handler;
        }
    }
}
