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
        /// Given a list of Weather with min and max temperatures, find the Weather with
        /// the smallest difference between min and max.
        /// </summary>
        /// <param name="weatherList">List of Weather</param>
        /// <returns>Weather</returns>
        public static T CalculateSmallestSpread<T>(List<T> dataList) where T : BaseDataType
        {
            BaseDataType smallestSpreadData = null;

            foreach (BaseDataType data in dataList)
            {
                if (smallestSpreadData == null ||
                   (Math.Abs(data.Value2 - data.Value1) < Math.Abs(smallestSpreadData.Value2 - smallestSpreadData.Value1)))
                {
                    // New smallest spread.
                    smallestSpreadData = data;
                }
            }

            return (T)smallestSpreadData;
        }
    }
}
