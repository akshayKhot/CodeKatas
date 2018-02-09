using System;
using System.Collections.Generic;

namespace CodeKata.Katas
{
    public class AnagramFinder
    {
        private List<string> _anagrams;
        private BloomFilter _filter;

        public AnagramFinder(BloomFilter filter)
        {
            _filter = filter;
        }

        public void FindAllAnagrams(IEnumerable<string> wordList)
        {
            foreach (var word in wordList)
            {
                FindAnagrams(word);
                Console.WriteLine();
            }
        }

        private void FindAnagrams(string word)
        {
            Console.Write($"{word} -> ");
            _anagrams = new List<string>();
            Permutation("", word);
            DisplayAnagrams();
        }

        private void DisplayAnagrams()
        {
            foreach (var anagram in _anagrams)
            {
                if(_filter.Test(anagram))
                    Console.Write($"{anagram} ");
            }
        }
        
        private void Permutation(String prefix, String str)
        {
            var n = str.Length;
            if (n == 0)
            {
                _anagrams.Add(prefix);
            }
            else {
                for (var i = 0; i < n; i++)
                    Permutation(prefix + str[i], str.Substring(0, i) + str.Substring(i+1, n-i-1));
            }
        }
    }
}