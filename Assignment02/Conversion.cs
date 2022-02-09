using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    public class Conversion
    {
        public double ConvertCelciusToFahrenheit(int input)
        {
            double degreeFahrenheit = (input * 9 / 5 ) + 32;
            return degreeFahrenheit;
        }
        public double ConvertCelciusToKelvin(int input)
        {
            double degreeKevin = input + 273.15;
            return degreeKevin;
        }
        public double ConvertKelvinToFahrenheit(int input)
        {
            double degreeFahrenheit = (((input - 273.15) * 9) / 5) + 32;
            return degreeFahrenheit;
        }
        public double ConvertKelvinToCelsius(int input)
        {
            double degreeCelcius = input - 273.15;
            return degreeCelcius;
        }
        public double ConvertFahrenheitToKelvin(int input)
        {
            double degreeKelvin = (((input - 32) * 5)/ 9) + 273.15;
            return degreeKelvin;
        }
        public double ConvertFahrenheitToCelsius(int input)
        {
            double degreeCelsius = (input - 32) * 5 / 9;
            return degreeCelsius;
        }
    }
}
