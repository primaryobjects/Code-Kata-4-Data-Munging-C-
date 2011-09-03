using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using CodeKata4.Types;

namespace CodeKata4.DataParser
{
    public static class Parser
    {
        public static List<Weather> ParseWeather(string path)
        {
            List<Weather> weatherList = new List<Weather>();

            string text = File.ReadAllText(path);

            Regex regEx = new Regex(@".*  (\d{1,2})  (\d{1,3}) +(\d{1,3})", RegexOptions.IgnoreCase);
            MatchCollection matches = regEx.Matches(text);

            foreach (Match match in matches)
            {
                if (match.Groups.Count >= 3)
                {
                    Weather weather = new Weather(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
                    weatherList.Add(weather);
                }
            }

            return weatherList;
        }

        public static List<Football> ParseFootball(string path)
        {
            List<Football> footballList = new List<Football>();

            string text = File.ReadAllText(path);

            Regex regEx = new Regex(@".*\. (\w+) +\d+ +\d+ +\d+ +\d+ +(\d+) +- +(\d+)", RegexOptions.IgnoreCase);
            MatchCollection matches = regEx.Matches(text);

            foreach (Match match in matches)
            {
                if (match.Groups.Count >= 3)
                {
                    Football football = new Football(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
                    footballList.Add(football);
                }
            }

            return footballList;
        }
    }
}
