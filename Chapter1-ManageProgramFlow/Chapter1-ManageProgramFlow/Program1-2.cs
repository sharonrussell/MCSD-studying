using System;
using System.Threading;

namespace Chapter1_ManageProgramFlow
{
    // an example of background threads
    public class Program1_2
    {
        private static void ThreadMethod()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread proc {i}");
                Thread.Sleep(1000);
            }
        }

        //public static void Main()
        //{
        //    var t = new Thread(new ThreadStart(ThreadMethod)) {IsBackground = true};
        //    t.Start();
        //}
    }
}
