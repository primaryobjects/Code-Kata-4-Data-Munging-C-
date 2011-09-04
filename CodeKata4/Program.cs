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
            List<Weather> weatherList = Parser.Parse("../../../weather.dat", (a,b,c) => new Weather(a, b, c));
            Driver(weatherList);

            List<Football> footballList = Parser.Parse("../../../football.dat", (a, b, c) => new Football(a, b, c));
            Driver(footballList);

            Console.ReadKey();
        }

        private static void Driver<T>(List<T> list) where T : BaseValueCompareType
        {
            T data = DataManager.CalculateSmallestSpread(list);
            Console.WriteLine(data.ToString());
        }
    }
}
