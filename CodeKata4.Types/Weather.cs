using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata4.Types
{
    public class Weather : BaseValueCompareType
    {
        public int Day { get { return Int32.Parse(Name); } set { Name = value.ToString(); } }
        public int MaxTemperature { get { return Value1; } set { Value1 = value; } }
        public int MinTemperature { get { return Value2; } set { Value2 = value; } }
        public override string RegularExpression { get { return @".*  (\d{1,2})  (\d{1,3}) +(\d{1,3})"; } }

        public Weather()
        {
        }

        public Weather(string day, string maxTemperature, string minTemperature)
            : base(day, Int32.Parse(maxTemperature), Int32.Parse(minTemperature))
        {
        }
    }
}
