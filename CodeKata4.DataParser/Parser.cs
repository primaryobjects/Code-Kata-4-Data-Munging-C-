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
        public static List<Weather> Parse(string path)
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
    }
}
