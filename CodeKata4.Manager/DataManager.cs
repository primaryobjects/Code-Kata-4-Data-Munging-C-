using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeKata4.Types;

namespace CodeKata4.Manager
{
    public static class DataManager
    {
        /// <summary>
        /// Given a list of BaseDataType with min and max values, find the BaseDataType with
        /// the smallest difference between Value1 and Value2.
        /// </summary>
        /// <param name="weatherList">List of BaseDataType</param>
        /// <returns>BaseDataType</returns>
        public static T CalculateSmallestSpread<T>(List<T> dataList) where T : BaseValueCompareType
        {
            var sortedList = dataList.OrderBy(x => x.ValueDifference).ToList();

            return sortedList.First();
        }
    }
}
