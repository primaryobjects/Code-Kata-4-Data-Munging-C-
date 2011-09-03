using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata4.Types
{
    public class Weather
    {
        public int Day { get; set; }
        public int MaxTemperature { get; set; }
        public int MinTemperature { get; set; }

        public Weather(int day, int maxTemperature, int minTemperature)
        {
            Day = day;
            MaxTemperature = maxTemperature;
            MinTemperature = minTemperature;
        }

        public Weather(string day, string maxTemperature, string minTemperature)
            : this(Int32.Parse(day), Int32.Parse(maxTemperature), Int32.Parse(minTemperature))
        {
        }

        public override string ToString()
        {
            return "Day: " + Day + ", Max: " + MaxTemperature + ", Min: " + MinTemperature;
        }
    }
}
