using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a temperature in Fahrenheit");
            var userInput  = double.Parse(Console.ReadLine());
            Console.WriteLine(TempConverter.FahrenheitToCelcius(userInput));
            Console.WriteLine("Input a temperature in Celcius");
            var userInput2 = double.Parse(Console.ReadLine());
            Console.WriteLine(TempConverter.CelciusToFahrenheit(userInput2));
        }
    }
}
