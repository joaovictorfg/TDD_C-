using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema1
{


public class TemperaturaCelsius
    {
        private double celsius;
        public TemperaturaCelsius(double celsius) //construtor
        {
            this.celsius = celsius;
        }

        public double converteCelsiusParaFahrenheit()
        {
            double fahrenheit = 1.8 * celsius + 32;
            return fahrenheit;
        }
    }
}