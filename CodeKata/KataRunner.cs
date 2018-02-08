using System;
using CodeKata.Katas;

namespace CodeKata
{
    public class KataRunner
    {
        public void Kata02()
        {
            // Kata 02: Karate Chop
            int[] numbers = { 4, 6, 10, 14, 18, 23, 34, 58 };
            var numberToSearch = -10;

            var finder = new BinarySearch();
            var location = finder.binary_search(numbers, numberToSearch);

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine($"Location of {numberToSearch} is {location}");
        }

        public void Kata04A()
        {
            var day = WeatherParser.GetDayWithSmallestSpread("/Users/akshaykhot/workspace/craftsmanship/CodeKata/CodeKata/Resources/weather.txt");
            Console.WriteLine($"The day with the smallest temperature spread is: {day}");   
        }

        public void Kata04B()
        {
            var team = FootballParser.GetTeamWithLowestDifference("/Users/akshaykhot/workspace/craftsmanship/CodeKata/CodeKata/Resources/football.txt");
            Console.WriteLine($"The team with the lowest goal difference is: {team}");
        }

        public void Kata05()
        {
            var filter = new BloomFilter(int.MaxValue);
            filter.Add("Akshay");
            filter.Add("David");
            filter.Add("Jason");
            filter.Add("Basecamp");
            filter.Add("CityView");

            var existJason = filter.Test("Jason");
            var existsNot = filter.Test("DHH");
        }
    }
}