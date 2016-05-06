using System;
using System.Threading;

namespace Chapter1_ManageProgramFlow
{
    // an example of threads and context switching
    public static class Program1_1
    {
        private static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread proc {0}", i);
                Thread.Sleep(0);
            }
        }

        //public static void Main()
        //{
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    t.Start();

        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine("Main thread: Do some work.");
        //        Thread.Sleep(0);
        //    }

        //    t.Join();
        //}
    }
}
