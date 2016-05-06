using System;
using System.Threading;

namespace Chapter1_ManageProgramFlow
{
    // an example of passing some data to the start method of thread using 
    // parmeterized thread start
    public class Program1_3
    {
        private static void ThreadMethod(object o)
        {
            for (var i = 0; i < (int) o; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        //public static void Main()
        //{
        //    var t = new Thread(new ParameterizedThreadStart(ThreadMethod));
        //    t.Start(10);
        //    t.Join();
        //}
    }
}
