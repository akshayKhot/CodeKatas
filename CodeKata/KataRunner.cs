using System;
using System.Collections.Generic;
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

        // Weather
        public void Kata04A()
        {
            var day = WeatherParser.GetDayWithSmallestSpread("/Users/akshaykhot/workspace/craftsmanship/CodeKata/CodeKata/Resources/weather.txt");
            Console.WriteLine($"The day with the smallest temperature spread is: {day}");   
        }

        // Soccer
        public void Kata04B()
        {
            var team = FootballParser.GetTeamWithLowestDifference("/Users/akshaykhot/workspace/craftsmanship/CodeKata/CodeKata/Resources/football.txt");
            Console.WriteLine($"The team with the lowest goal difference is: {team}");
        }

        // Bloom Filters
        public void Kata05()
        {
            // need to implement the second part of the bloom filters
            var filter = Helper.FillBloomFilter();

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

        // Find anagrams of words in a dictionary
        public void Kata06()
        {
            var filter = Helper.FillBloomFilter();
            var anagram = new AnagramFinder(filter);
            var wordList = Helper.GetTestWords();
            anagram.FindAllAnagrams(wordList);
        }

        // Count the lines of code
        public void Kata07()
        {
            var counter = new LineCounter();
            var count = counter.CountLinesOfCode("/Users/akshaykhot/workspace/craftsmanship/CodeKata/CodeKata/Katas/FootballParser.cs");
            Console.WriteLine($"Lines of Code: {count}" );
        }
        
    }
}