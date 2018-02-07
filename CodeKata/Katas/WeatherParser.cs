using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeKata.Katas
{
    public static class WeatherParser
    {
        public static string GetDayWithSmallestSpread()
        {
            var pattern = @"\s+";
            
            var lines = File.ReadLines("/Users/akshaykhot/workspace/craftsmanship/CodeKata/CodeKata/Resources/weather.txt").Skip(2);
            lines = lines.Take(lines.Count() - 1);
            
            var smallestSpread = int.MaxValue;
            var dayWithSmallestSpread = "";
            foreach (var line in lines)
            {
                var result = Regex.Split(line, pattern);
                var maxT = GetTemp(result[2]);
                var minT = GetTemp(result[3]);

                var spread = maxT - minT;
                if (spread < smallestSpread)
                {
                    smallestSpread = spread;
                    dayWithSmallestSpread = result[1];
                }
            }

            return dayWithSmallestSpread;
        }

        private static int GetTemp(string temp)
        {
            var strTemp = temp.Replace("*", "");
            var numtemp = int.Parse(strTemp);
            return numtemp;
        }
    }
}