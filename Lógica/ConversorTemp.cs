using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public static class ConversorTemp
    {
        //11- Crear una clase estática que contenga dos métodos que convierten la temperatura de grados Celsius a grados Fahrenheit y viceversa 
        //(f = c * 2.12; c = f / 2.12).

        public static double CelsiusAFahrenheit(string temperaturaCelsius)
        {
            double celsius = Double.Parse(temperaturaCelsius);
            double fahrenheit = (celsius * 2.12);
            return fahrenheit;
        }

        public static double FahrenheitACelsius(string temperaturaFahrenheit)
        {
            double fahrenheit = Double.Parse(temperaturaFahrenheit);
            double celsius = (fahrenheit / 2.12);
            return celsius;
        }
    }
}
