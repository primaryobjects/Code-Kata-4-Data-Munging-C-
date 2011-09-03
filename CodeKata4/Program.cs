using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeKata4.DataParser;
using CodeKata4.Types;
using CodeKata4.Manager;

namespace CodeKata4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Weather> weatherList = Parser.Parse(@"C:\users\nada\desktop\weather.dat");
            Weather weather = WeatherManager.CalculateSmallestSpread(weatherList);

            Console.WriteLine(weather.ToString());

            Console.ReadKey();
        }
    }
}
