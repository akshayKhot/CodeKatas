using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeKata.Katas.Shared
{
    public static class Helper
    {
        private const string DictionaryPath = "/usr/share/dict/words";
        
        public static BloomFilter FillBloomFilter()
        {
            var filter = new BloomFilter(int.MaxValue);
            
            var words = PopulateWords();
            foreach (var word in words)
            {
                filter.Add(word);
            }
            
            return filter;
        }

        private static IEnumerable<string> PopulateWords()
        {
            var words = File.Exists(DictionaryPath) ? 
                File.ReadAllLines(DictionaryPath) : 
                new[] { "abc", "def" };
            
            return words;
        }

        public static IEnumerable<string> GetTestWords()
        {
            return PopulateWords();
            //return new string[] { "rwite", "tternpa", "tra" };
        }
    }
}