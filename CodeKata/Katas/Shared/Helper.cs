using System.IO;

namespace CodeKata.Katas.Shared
{
    public class Helper
    {
        public static BloomFilter FillBloomFilter(string path)
        {
            var filter = new BloomFilter(int.MaxValue);
            
            if (File.Exists(path))
            {
                var words = File.ReadAllLines(path);
                foreach (var word in words)
                {
                    filter.Add(word);
                }
            }

            return filter;
        }
    }
}