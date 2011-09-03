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
        /// <summary>
        /// Parses a text file of data for a specific type.
        /// </summary>
        /// <typeparam name="T">Type of data</typeparam>
        /// <param name="path">Path name</param>
        /// <param name="construct">Constructor expression</param>
        /// <returns>List of Type</returns>
        public static List<T> Parse<T>(string path, Func<string, string, string, T> construct) where T : BaseDataType
        {
            List<T> dataList = new List<T>();

            string text = File.ReadAllText(path);

            Regex regEx = new Regex(GetPattern(typeof(T)), RegexOptions.IgnoreCase);
            MatchCollection matches = regEx.Matches(text);

            foreach (Match match in matches)
            {
                if (match.Groups.Count >= 3)
                {
                    T data = construct(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
                    dataList.Add(data);
                }
            }

            return dataList;
        }

        /// <summary>
        /// Returns a regular expression to parse a given type.
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>string</returns>
        private static string GetPattern(Type type)
        {
            string pattern = "";

            switch (type.Name)
            {
                case "Weather": pattern = @".*  (\d{1,2})  (\d{1,3}) +(\d{1,3})"; break;
                case "Football": pattern = @".*\. (\w+) +\d+ +\d+ +\d+ +\d+ +(\d+) +- +(\d+)"; break;
                default: throw new Exception("Unknown type to parse: " + type.Name);
            }

            return pattern;
        }
    }
}
