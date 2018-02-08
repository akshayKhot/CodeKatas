using System;
using CodeKata.Katas;
using CodeKata.Katas.Shared;

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
            var filter = Helper.FillBloomFilter("/usr/share/dict/words");

            while (true)
            {
                Console.Write("Enter the word.. ");
                var word = Console.ReadLine();
                if(word == "quit")
                    break;
                
                Console.WriteLine(filter.Test(word)
                    ? $"{word} might be in the dictionary"
                    : $"{word} doesn't exist for sure");   
            }

            Console.WriteLine("Thank you for using the dictionary. Good Bye..");
        }
        
    }
}