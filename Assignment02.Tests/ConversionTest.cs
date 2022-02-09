using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment02.Tests
{
    public class ConversionTest
    {
        [Test]
        public void Conversion_IfFahrenheit86_Celius30()
        {
            Conversion conversion = new Conversion();
            int fahrenheightValue = 86;
            double convertedValue = conversion.ConvertFahrenheitToCelsius(fahrenheightValue);
            Assert.AreEqual(30, convertedValue);
        }
        public void Conversion_IfFahrenheit65_Celius18()
        {
            Conversion conversion = new Conversion();
            int fahrenheightValue = 65;
            double convertedValue = conversion.ConvertFahrenheitToCelsius(fahrenheightValue);
            Assert.AreEqual(18, convertedValue);
        }
        public void Conversion_IfFahrenheit167_Celius75()
        {
            Conversion conversion = new Conversion();
            int fahrenheightValue = 167;
            double convertedValue = conversion.ConvertFahrenheitToCelsius(fahrenheightValue);
            Assert.AreEqual(75, convertedValue);
        }

        [Test]
        public void Conversion_IfCelius30_FahrenheitIs86()
        {
            Conversion conversion = new Conversion();
            int celciusValue = 30;
            double convertedValue = conversion.ConvertCelciusToFahrenheit(celciusValue);
            Assert.AreEqual(86, convertedValue);
        }
        public void Conversion_IfCelius160_FahrenheitIs320()
        {
            Conversion conversion = new Conversion();
            int celciusValue = 160;
            double convertedValue = conversion.ConvertCelciusToFahrenheit(celciusValue);
            Assert.AreEqual(320, convertedValue);
        }
        public void Conversion_IfCelius95_FahrenheitIs203()
        {
            Conversion conversion = new Conversion();
            int celciusValue = 95;
            double convertedValue = conversion.ConvertCelciusToFahrenheit(celciusValue);
            Assert.AreEqual(203, convertedValue);
        }
        public void Conversion_IfCelcius4_Kelvin277()
        {
            Conversion Conversion = new Conversion();
            int celciusvalue = 4;
            double convertedvalue = Conversion.ConvertCelciusToKelvin(celciusvalue);
            Assert.AreEqual(277, convertedvalue);
        }
        public void Conversion_IfCelcius9_Kelvin282()
        {
            Conversion Conversion = new Conversion();
            int celciusvalue = 9;
            double convertedvalue = Conversion.ConvertCelciusToKelvin(celciusvalue);
            Assert.AreEqual(282, convertedvalue);
        }
        public void Conversion_IfCelcius15_Kelvin288()
        {
            Conversion Conversion = new Conversion();
            int celciusvalue = 15;
            double convertedvalue = Conversion.ConvertCelciusToKelvin(celciusvalue);
            Assert.AreEqual(288, convertedvalue);
        }
        public void Convert_IfKelvin10_Fahrenheit441()
        {
            Conversion Conversion = new Conversion();
            int kelvinvalue = 10;
            double convetedvalue = Conversion.ConvertKelvinToFahrenheit(kelvinvalue);
            Assert.AreEqual(441, convetedvalue);
        }
        public void Convert_IfKelvin35_Fahrenheit396()
        {
            Conversion Conversion = new Conversion();
            int kelvinvalue = 35;
            double convetedvalue = Conversion.ConvertKelvinToFahrenheit(kelvinvalue);
            Assert.AreEqual(396, convetedvalue);
        }
        public void Convert_IfKelvin46_Fahrenheit376()
        {
            Conversion Conversion = new Conversion();
            int kelvinvalue = 46;
            double convetedvalue = Conversion.ConvertKelvinToFahrenheit(kelvinvalue);
            Assert.AreEqual(376, convetedvalue);
        }
        public void Convert_IfKelvin10_Celcius263()
        {
            Conversion Conversion = new Conversion();
            int kelvinvalue = 10;
            double convertedvalue = Conversion.ConvertKelvinToCelsius(kelvinvalue);
            Assert.AreEqual(263, convertedvalue);
        }
        public void Convert_IfKelvin90_Celcius183()
        {
            Conversion Conversion = new Conversion();
            int kelvinvalue = 90;
            double convertedvalue = Conversion.ConvertKelvinToCelsius(kelvinvalue);
            Assert.AreEqual(183, convertedvalue);
        }
        public void Convert_IfKelvin73_Celcius200()
        {
            Conversion Conversion = new Conversion();
            int kelvinvalue = 73;
            double convertedvalue = Conversion.ConvertKelvinToCelsius(kelvinvalue);
            Assert.AreEqual(200, convertedvalue);
        }
        public void Convert_IfFahrenheit32_Kelvin273()
        {
            Conversion Conversion = new Conversion();
            int Fahrenheitvalue = 32;
            double convertedvalue = Conversion.ConvertFahrenheitToKelvin(Fahrenheitvalue);
            Assert.AreEqual(273, convertedvalue);
        }
        public void Convert_IfFahrenheit96_Kelvin308()
        {
            Conversion Conversion = new Conversion();
            int Fahrenheitvalue = 96;
            double convertedvalue = Conversion.ConvertFahrenheitToKelvin(Fahrenheitvalue);
            Assert.AreEqual(308, convertedvalue);
        }
        public void Convert_IfFahrenheit63_Kelvin290()
        {
            Conversion Conversion = new Conversion();
            int Fahrenheitvalue = 63;
            double convertedvalue = Conversion.ConvertFahrenheitToKelvin(Fahrenheitvalue);
            Assert.AreEqual(290, convertedvalue);
        }





    }
