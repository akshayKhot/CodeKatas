using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeKata.Katas
{
    public static class WeatherParser
    {
        public static string GetDayWithSmallestSpread(string path)
        {
            var dayWithSmallestSpread = "";
            var smallestSpread = int.MaxValue;

            var lines = Parser.ReadLines(path);
            foreach (var line in lines)
            {
                if (Parser.IsInvalidLine(line)) continue;
                
                var tokens = Parser.GetTokens(line);
                var spread = Parser.GetDifference(tokens[2], tokens[3]);
                
                if (spread < smallestSpread)
                {
                    smallestSpread = spread;
                    dayWithSmallestSpread = tokens[1];
                }
            }

            return dayWithSmallestSpread;
        }

        
    }
}