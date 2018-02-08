using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using CodeKata.Katas.Interfaces;

namespace CodeKata.Katas
{
    public class BloomFilter : IFilter
    {
        private readonly BitArray _bitArray;

        public BloomFilter(int size)
        {
            _bitArray = new BitArray(size);
        }

        public void Add(string word)
        {
            var hashedValue = GetHashValue(word);
            _bitArray.Set(hashedValue, true);
        }

        public bool Test(string word)
        {
            var hashedValue = GetHashValue(word);
            return _bitArray.Get(hashedValue);
        }

        private static int GetHashValue(string word)
        {
            var md5Hasher = MD5.Create();
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(word));
            var hashedValue = BitConverter.ToInt32(hashed, 0);
            return Math.Abs(hashedValue);
        }
    }
}