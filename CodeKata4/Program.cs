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
            List<Weather> weatherList = Parser.ParseWeather(@"C:\users\nada\desktop\weather.dat");
            Weather weather = DataManager.CalculateSmallestSpread(weatherList);
            Console.WriteLine(weather.ToString());

            List<Football> footballList = Parser.ParseFootball(@"C:\users\nada\desktop\football.dat");
            Football football = DataManager.CalculateSmallestSpread(footballList);
            Console.WriteLine(football.ToString());

            Console.ReadKey();
        }
    }
}
