using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Thermostat
    {
        public event EventHandler TemperatureChanged;

        private double temperature;

        public double Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                OnTemperatureChanged();
            }
        }

        protected virtual void OnTemperatureChanged()
        {
            TemperatureChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
