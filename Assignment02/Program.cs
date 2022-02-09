using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean validIntegerInput = false;
            Boolean validMenuInput = false;
            string sInput = "";
            string sMenuInput = "";
            double convertedValue = 0;
            int numberInput = 0;
            do
            {
                Console.Write("Please enter a number (must be > 0) : ");
                sInput = Console.ReadLine();
                if (int.TryParse(sInput, out int value))
                {
                    validIntegerInput = true;
                    numberInput = int.Parse(sInput);
                }
                else
                {
                    Console.Write("Invalid Input \n");
                }
            } while (!validIntegerInput);

            do
            {
                Console.Write("\n");
                Console.Write("Please choose one of the following options: \n");
                Console.Write("1. Convert Celsius to Fahrenheit\n");
                Console.Write("2. Convert Celsius to Kelvin\n");
                Console.Write("3. Convert Fahrenheit to Celsius\n");
                Console.Write("4. Convert Fahrenheit to Kelvin\n");
                Console.Write("5. Convert Kelvin to Celsius\n");
                Console.Write("6. Convert Kelvin to Fahrenheit\n");
                Console.Write("7. Exit\n");
                sMenuInput = Console.ReadLine();
                if (int.TryParse(sMenuInput, out int value))
                {
                    if(sMenuInput == "1" || sMenuInput == "2" || sMenuInput == "3" || sMenuInput == "4" || sMenuInput == "5" || sMenuInput == "6" || sMenuInput == "7")
                        validMenuInput = true;
                    else
                        Console.Write("Invalid Input \n");
                }
                else
                {
                    Console.Write("Invalid Input \n");
                }
            } while (!validMenuInput);

            Conversion conversion = new Conversion();
            switch (sMenuInput)
            {
                case "1":
                    convertedValue = conversion.ConvertCelciusToFahrenheit(numberInput);
                    Console.Write(numberInput + " degrees Celsius is " + convertedValue + " degrees Fahrenheit");
                    break;
                case "2":
                    convertedValue = conversion.ConvertCelciusToKelvin(numberInput);
                    Console.Write(numberInput + " degrees Celsius is " + convertedValue + " degrees Kelvin");
                    break;
                case "3":
                    convertedValue = conversion.ConvertFahrenheitToCelsius(numberInput);
                    Console.Write(numberInput + " degrees Fahrenheit is " + convertedValue + " degrees Celsius");
                    break;
                case "4":
                    convertedValue = conversion.ConvertFahrenheitToKelvin(numberInput);
                    Console.Write(numberInput + " degrees Fahrenheit is " + convertedValue + " degrees Kelvin");
                    break;
                case "5":
                    convertedValue = conversion.ConvertKelvinToCelsius(numberInput);
                    Console.Write(numberInput + " degrees Kelvin is " + convertedValue + " degrees Celsius");
                    break;
                case "6":
                    convertedValue = conversion.ConvertKelvinToFahrenheit(numberInput);
                    Console.Write(numberInput + " degrees Kelvin is " + convertedValue + " degrees Fahrenheit");
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
