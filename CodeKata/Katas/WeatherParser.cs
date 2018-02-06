using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeKata.Katas
{
    public class WeatherParser
    {
        public string getDayWithSmallestSpread()
        {
            var pattern = @"\s+";
            // Read the file
            var lines = File.ReadLines("/Users/akshaykhot/workspace/craftsmanship/CodeKata/CodeKata/Resources/weather.txt").Skip(2);
            lines = lines.Take(lines.Count() - 1);
            
            var smallestSpread = Int32.MaxValue;
            string dayWithSmallestSpread = "";
            foreach (var line in lines)
            {
                string[] result = Regex.Split(line, pattern);
                var maxT = getTemp(result[2]);
                var minT = getTemp(result[3]);

                var spread = maxT - minT;
                if (spread < smallestSpread)
                {
                    smallestSpread = spread;
                    dayWithSmallestSpread = result[1];
                }
            }

            return dayWithSmallestSpread;

            // For each line, find the difference between 2nd and 3rd column

            // Choose the line with the smallest difference

            // Return the day for that line
        }

        public int getTemp(string temp)
        {
            var strTemp = temp.Replace("*", "");
            var numtemp = Int32.Parse(strTemp);
            return numtemp;
        }
    }
}