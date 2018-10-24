using System;

namespace OpenWeatherMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What city would you like to check the temperature?");
            string city = Console.ReadLine();

            CheckWeather checkWeather = new CheckWeather();


        }
    }
}
