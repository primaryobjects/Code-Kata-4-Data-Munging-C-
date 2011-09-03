using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeKata4.Types;

namespace CodeKata4.Manager
{
    public static class WeatherManager
    {
        /// <summary>
        /// Given a list of Weather with min and max temperatures, find the Weather with
        /// the smallest difference between min and max.
        /// </summary>
        /// <param name="weatherList">List of Weather</param>
        /// <returns>Weather</returns>
        public static Weather CalculateSmallestSpread(List<Weather> weatherList)
        {
            Weather smallestSpreadWeather = null;

            foreach (Weather weather in weatherList)
            {
                if (smallestSpreadWeather == null ||
                   ((weather.MaxTemperature - weather.MinTemperature) < (smallestSpreadWeather.MaxTemperature - smallestSpreadWeather.MinTemperature)))
                {
                    // New smallest spread.
                    smallestSpreadWeather = weather;
                }
            }

            return smallestSpreadWeather;
        }
    }
}
