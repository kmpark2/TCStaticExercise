using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius(double fTemp)
        {
            var result = (fTemp - 32) / 1.8;
            return result;
        }
        public static double CelciusToFahrenheit(double cTemp)
        {
            var result = (cTemp * 1.8) + 32;
            return result;
        }
    }
}
