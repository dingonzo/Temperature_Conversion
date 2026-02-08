using System;

namespace Week1CLIv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Temperature Converter ---");
            Console.WriteLine("1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Fahrenheit to Celsius");
            Console.Write("Select an option (1 or 2): ");
            string choice = Console.ReadLine();

            Console.Write("Enter the temperature value: ");
            float inputTemp = float.Parse(Console.ReadLine());

            if (choice == "1")
            {
                float result = ToFahrenheit(inputTemp);
                Console.WriteLine($"{inputTemp}°C is {result:F2}°F");
            }
            else if (choice == "2")
            {
                float result = ToCelsius(inputTemp);
                Console.WriteLine($"{inputTemp}°F is {result:F2}°C");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please restart and pick 1 or 2.");
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        
        private static float ToFahrenheit(float celsius)
        {
            return (celsius * 1.8f) + 32;
        }

        private static float ToCelsius(float fahrenheit)
        {
            // Using the fraction 5/9 for better precision
            return (fahrenheit - 32) * (5f / 9f);
        }
    }
}