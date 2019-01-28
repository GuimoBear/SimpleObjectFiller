using SimpleObjectFiller.Generators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace SimpleObjectFiller.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            Console.WriteLine("Generate random values from Random class");
            watch.Start();
            RandomClassGenerator().ToList();
            watch.Stop();
            Console.WriteLine("\tElapsed time: " + watch.Elapsed.ToString());
            Console.WriteLine("Generate random values from custom random class");
            watch.Start();
            CustomRandomClassGenerator().ToList();
            watch.Stop();
            Console.WriteLine("\tElapsed time: " + watch.Elapsed.ToString());
            Console.WriteLine("Generate random values from ticks in DateTime.Now");
            watch.Start();
            RandomTocksGenerator().ToList();
            watch.Stop();
            Console.WriteLine("\tElapsed time: " + watch.Elapsed.ToString());
            Console.ReadKey();
        }
        
        public static IEnumerable<int> RandomClassGenerator()
        {
            var rnd = new Random();
            for (int i = 0; i < 100_000_000; i++)
            {
                var value = rnd.Next();
                if (value % 50 == 1)
                    yield return value;
            }
        }

        public static IEnumerable<int> CustomRandomClassGenerator()
        {
            var rnd = new RandomGenerator();
            for (int i = 0; i < 100_000_000; i++)
            {
                var value = rnd.Next();
                if(value % 50 == 1)
                    yield return value;
            }
        }

        public static IEnumerable<long> RandomTocksGenerator()
        {
            for (int i = 0; i < 100_000_000; i++)
            {
                var value = DateTime.Now.Ticks;
                if (value % 50 == 1)
                    yield return value;
            }
        }
    }
}
