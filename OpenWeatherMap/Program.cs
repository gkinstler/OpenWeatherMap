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
            string reply = webClient.DownloadString("https://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=" + API_KEY);

            Console.WriteLine(reply);

            Console.ReadLine();


        }
    }
}
