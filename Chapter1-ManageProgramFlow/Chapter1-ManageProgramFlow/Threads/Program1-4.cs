using System;
using System.Threading;

namespace Chapter1_ManageProgramFlow
{
    // an example of stopping a thread using a shared variable
    // the thread is initialized with a lambda expression
    public class Program1_4
    {
        //public static void Main()
        //{
        //    var stopped = false;
            
        //    var t = new Thread(() =>
        //    {
        //        while (!stopped)
        //        {
        //            Console.WriteLine("Running...");
        //            Thread.Sleep(1000);    
        //        }
        //    });

        //    t.Start();
        //    Console.WriteLine("Press any key to exit");
        //    Console.ReadKey();

        //    Console.WriteLine("Stopped");

        //    stopped = true;
        //    t.Join();
        //}
    }
}
