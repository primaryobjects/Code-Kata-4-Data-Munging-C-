using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata4.Types
{
    public class Football : BaseDataType
    {
        public int ScoresFor { get { return Value1; } set { Value1 = value; } }
        public int ScoresAgainst { get { return Value2; } set { Value2 = value; } }

        public Football(string name, int maxValue, int minValue)
            : base(name, maxValue, minValue)
        {
        }

        public Football(string name, string maxValue, string minValue)
            : base(name, Int32.Parse(maxValue), Int32.Parse(minValue))
        {
        }
    }
}
