using System;
using System.Runtime.CompilerServices;

namespace CodeKata
{
    class Program
    {
        public static KataRunner Runner { get; set; }
        
        static void Main(string[] args)
        {
            Runner = new KataRunner();
            Runner.Kata04B();
        }
    }
}