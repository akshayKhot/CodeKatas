
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeKata.Katas
{
    public static class FootballParser
    {
        public static string GetTeamWithLowestDifference()
        {
            var teamWithMinimumDifference = "";
            var lines = File.ReadAllLines(
                "/Users/akshaykhot/workspace/craftsmanship/CodeKata/CodeKata/Resources/football.txt").Skip(1).ToList();
            lines.RemoveAll(line => line.Contains("-----"));
            // parse each line into an array of strings, separated by one or more spaces
            var pattern = @"\s+";
            var minimumGoalDifference = int.MaxValue;
            foreach (var line in lines)
            {
                var tokens = Regex.Split(line, pattern);
                var forGoals = int.Parse(tokens[7]);
                var againstGoals = int.Parse(tokens[9]);
                var goalDifference = Math.Abs(forGoals - againstGoals);

                if (goalDifference < minimumGoalDifference)
                {
                    minimumGoalDifference = goalDifference;
                    teamWithMinimumDifference = tokens[2];
                }
            }
            
            
            return teamWithMinimumDifference;
        }
    }
}