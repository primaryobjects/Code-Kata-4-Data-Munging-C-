using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata4.Types
{
    public abstract class BaseValueCompareType
    {
        public string Name { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int ValueDifference
        {
            get
            {
                return Math.Abs(Value1 - Value2);
            }
        }

        public BaseValueCompareType(string name, int value1, int value2)
        {
            Name = name;
            Value1 = value1;
            Value2 = value2;
        }

        public BaseValueCompareType(string name, string value1, string value2)
            : this(name, Int32.Parse(value1), Int32.Parse(value2))
        {
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Value 1: " + Value1 + ", Value 2: " + Value2 + ", Diff: " + ValueDifference;
        }
    }
}
