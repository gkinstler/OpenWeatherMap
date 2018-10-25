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

            // using LONDON for the moment
            WebClient webClient = new WebClient();
            string reply = webClient.DownloadString("https://api.openweathermap.org/data/2.5/weather?zip=35222&&APPID=" + API_KEY);
            var kelvinTemp = JObject.Parse(reply)["main"]["temp"];
            var fahTemp = (1.8 * ((int)kelvinTemp - 273)) + 32;
                 
            Console.WriteLine("The temperature in Birmingham is currently " + fahTemp);

            Console.ReadLine();


        }
    }
}
