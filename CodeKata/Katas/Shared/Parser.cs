using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeKata.Katas.Shared
{
    public static class Parser
    {
        private static string pattern = @"\s+";
        
        public static List<string> ReadLines(string path)
        {
            var lines = File.ReadLines(path).ToList();
            return lines;
        }

        public static bool IsInvalidLine(string line)
        {
            var invalidLine =  string.IsNullOrWhiteSpace(line) || line.Contains("----") || 
                               line.Contains("Team") || line.Contains("Dy") || line.Contains("mo");

            return invalidLine;
        }

        private static int ParseToken(string token)
        {
            // Capture the number from the token 
            var escapedToken = Regex.Match(token, @"\d+").Value;
            //convert to int
            var numericToken = int.Parse(escapedToken);

            return numericToken;
        }

        public static int GetDifference(string token1, string token2)
        {
            var parsedToken1 = ParseToken(token1);
            var parsedToken2 = ParseToken(token2);

            return Math.Abs(parsedToken1 - parsedToken2);
        }

        public static string[] GetTokens(string line)
        {
            return Regex.Split(line, pattern);
        }
    }
}