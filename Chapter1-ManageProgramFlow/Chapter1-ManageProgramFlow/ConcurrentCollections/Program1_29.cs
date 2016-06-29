using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1_ManageProgramFlow.ConcurrentCollections
{
    public static class Program1_29
    {
        //public static void Main()
        //{
        //    var collection = new BlockingCollection<string>();

        //    Task.Run(() =>
        //    {
        //        foreach (var item in collection.GetConsumingEnumerable())
        //            Console.WriteLine(item);
        //    });

        //    var write = Task.Run(() =>
        //    {
        //        while (true)
        //        {
        //            var s = Console.ReadLine();
        //            if (string.IsNullOrWhiteSpace(s)) break;
        //            collection.Add(s);
        //        }
        //    });

        //    write.Wait();
        //}
    }
}