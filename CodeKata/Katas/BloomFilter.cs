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
            var md5Hash = GetMd5Hash(word);
            _bitArray.Set(md5Hash, true);

            var sha256Hash = GetSha256Hash(word);
            _bitArray.Set(sha256Hash, true);
        }

        public bool Test(string word)
        {
            var md5Hash = GetMd5Hash(word);
            var sha256Hash = GetSha256Hash(word);
            
            return _bitArray.Get(md5Hash) && _bitArray.Get(sha256Hash);
        }

        private static int GetMd5Hash(string word)
        {
            var md5Hasher = MD5.Create();
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(word));
            var hashedValue = BitConverter.ToInt32(hashed, 0);
            return Math.Abs(hashedValue);
        }
        
        private static int GetSha256Hash(string word)
        {
            var sha256Hasher = SHA256.Create();
            var hashed = sha256Hasher.ComputeHash(Encoding.UTF8.GetBytes(word));
            var hashedValue = BitConverter.ToInt32(hashed, 0);
            return Math.Abs(hashedValue);
        }
    }
}