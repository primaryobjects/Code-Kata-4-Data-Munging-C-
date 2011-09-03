using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata4.Types
{
    public abstract class BaseDataType
    {
        public string Name { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        
        public BaseDataType(string name, int maxValue, int minValue)
        {
            Name = name;
            Value2 = maxValue;
            Value1 = minValue;
        }

        public BaseDataType(string name, string maxValue, string minValue)
            : this(name, Int32.Parse(maxValue), Int32.Parse(minValue))
        {
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Max: " + Value2 + ", Min: " + Value1;
        }
    }
}
