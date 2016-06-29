using System;
using System.Collections.Concurrent;

namespace Chapter1_ManageProgramFlow.ConcurrentCollections
{
    // methods you can use on a concurrent dictionary
    public class Program1_34
    {
        public static void Main()
        {
            var dict = new ConcurrentDictionary<string, int>();

            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }

            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }

            dict["k1"] = 42;

            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i*2);
            int r2 = dict.GetOrAdd("k2", 3);

            Console.ReadKey();
        }
    }
}