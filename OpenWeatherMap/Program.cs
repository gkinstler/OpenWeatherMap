using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMap
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string API_KEY = "f289f525beaef39e4b93ae44743a09b8";

            Console.WriteLine("Enter a ZIP code: ");
            var zip = Console.ReadLine();
            Console.WriteLine("Grabbing data...");

            WebClient webClient = new WebClient();
            string reply = webClient.DownloadString($"https://api.openweathermap.org/data/2.5/weather?zip={zip}&APPID=" + API_KEY);
            var kelvinTemp = JObject.Parse(reply)["main"]["temp"];
            var longDesc = JObject.Parse(reply)["weather"][0]["description"];
            var windSpeed = JObject.Parse(reply)["wind"]["speed"];
            var windDirection = JObject.Parse(reply)["wind"]["deg"];
            var fahTemp = (1.8 * ((int)kelvinTemp - 273)) + 32;

            Console.WriteLine($"The temperature in {zip} is currently " + fahTemp);

            Console.WriteLine($"The skies are {longDesc}.");

            Console.WriteLine($"The wind speed is {windSpeed} mph from {windDirection}.");



            Console.ReadLine();


        }
    }
}
