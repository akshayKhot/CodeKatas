
using System;
using System.Linq;

namespace CodeKata.Katas
{
    public class BinarySearch
    {

        public int binary_search(int[] numbers, int numberToSearch)
        {
            var location = recursive_search(numbers, 0, numbers.Length - 1, numberToSearch);
            return location;
        }

        private int recursive_search(int[] numbers, int start, int end, int numberToSearch)
        {
            const int notFound = -1;
            
            if (start > end)
            {
                return notFound;
            }                 
            
            // find the middle element in the numbers
            var midLocation = (start + end) / 2;
            var middleElement = numbers[midLocation];

            // compare middle element with the numberToSearch
            if (middleElement == numberToSearch)
            {
                // if equals, return that element
                return midLocation;
            }

            if (numberToSearch < middleElement)
            {
                // if less, search in the left half of numbers
                return recursive_search(numbers, start, midLocation - 1, numberToSearch);
            }
            
            else
            {
                // if more, search in the right half of numbers
                return recursive_search(numbers, midLocation + 1, end, numberToSearch);
            }

            return notFound;
        }
    }
}