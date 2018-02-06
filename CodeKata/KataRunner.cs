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

        public void Kata04()
        {
            var parser = new WeatherParser();
            var day = parser.getDayWithSmallestSpread();
            Console.WriteLine($"The day with the smallest temperature spread is: {day}");
        }
    }
}