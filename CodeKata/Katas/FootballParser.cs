using CodeKata.Katas.Shared;

namespace CodeKata.Katas
{
    public static class FootballParser
    {
        public static string GetTeamWithLowestDifference(string path)
        {  
            var teamWithMinimumDifference = "";
            var minimumGoalDifference = int.MaxValue;
            
            var lines = Parser.ReadLines(path);
            foreach (var line in lines)
            {
                if (Parser.IsInvalidLine(line)) continue;

                var tokens = Parser.GetTokens(line);
                var goalDifference = Parser.GetDifference(tokens[7], tokens[9]);
                
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