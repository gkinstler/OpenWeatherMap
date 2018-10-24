using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMap
{
    class CheckWeather
    {
        private const string API_KEY = "f289f525beaef39e4b93ae44743a09b8";

        // using LONDON for the moment
        private const string CurrentConditions = "http://api.openweathermap.org/data/2.5/weather?" + "q=@LONDON@&mode=xml&units=imperial&APPID=" + API_KEY;
        
        // Get current conditions.
        public void getConditions
        {

        }
    }
}
