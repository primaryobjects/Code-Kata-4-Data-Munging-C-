using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata4.Types
{
    public class Weather : BaseValueCompareType
    {
        public int Day { get { return Int32.Parse(Name); } set { Name = value.ToString(); } }
        public int MaxTemperature { get { return Value2; } set { Value2 = value; } }
        public int MinTemperature { get { return Value1; } set { Value1 = value; } }

        public Weather(string day, string maxTemperature, string minTemperature)
            : base(day, Int32.Parse(maxTemperature), Int32.Parse(minTemperature))
        {
        }
    }
}
