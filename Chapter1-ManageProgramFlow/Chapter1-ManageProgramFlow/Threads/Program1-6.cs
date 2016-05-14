using System;
using System.Threading;

namespace Chapter1_ManageProgramFlow
{
    // example of using local data in each thread
    // and initializing for each thread
    public static class Program1_6
    {
        private static ThreadLocal<int> _field = new ThreadLocal<int>(() => Thread.CurrentThread.ManagedThreadId);

        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (var x = 0; x < _field.Value; x++)
        //        {
        //            Console.WriteLine($"Thread A: {_field}");
        //        }    
        //    }).Start();

        //    new Thread(() =>
        //    {
        //        for (var x = 0; x < _field.Value; x++)
        //        {
        //            Console.WriteLine($"Thread B: {_field}");
        //        }
        //    }).Start();

        //    Console.ReadKey();
        //}
    }
}
