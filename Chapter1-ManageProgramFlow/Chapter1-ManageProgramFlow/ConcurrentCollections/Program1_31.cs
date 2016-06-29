using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1_ManageProgramFlow.ConcurrentCollections
{
    // Only plays 42 because the other value is added after iterating over the bag has started
    public class Program1_31
    {
        //public static void Main()
        //{
        //    var bag = new ConcurrentBag<int>();

        //    Task.Run(() =>
        //    {
        //        bag.Add(42);
        //        Thread.Sleep(1000);
        //        bag.Add(21);
        //    });

        //    Task.Run(() =>
        //    {
        //        foreach (var i in bag)
        //            Console.WriteLine(i);
        //    }).Wait();
        //}
    }
}