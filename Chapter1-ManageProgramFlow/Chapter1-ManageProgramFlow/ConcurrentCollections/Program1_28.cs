using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1_ManageProgramFlow.ConcurrentCollections
{
    // program terminates when user doesn't enter any data: hit enter
    // every string entered is added by the write task and removed by the read task
    // example of using a blocking collection
    public static class Program1_28
    {
        //public static void Main()
        //{
        //    var collection = new BlockingCollection<string>();

        //    var read = Task.Run(() =>
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine(collection.Take());
        //        }
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