using System;
using System.Threading;

namespace Chapter1_ManageProgramFlow
{
    // example use of threadstatic where both threads have its own copy
    // of _field. The max _field will get to is ten.
    public class Program1_5
    {
        //[ThreadStatic] private static int _field;
        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (var x = 0; x < 10; x++)
        //        {
        //            _field++;
        //            Console.WriteLine($"Thread A: {_field}");
        //        }
        //    }).Start();

        //    new Thread(() =>
        //    {
        //        for (var x = 0; x < 10; x++)
        //        {
        //            _field++;
        //            Console.WriteLine($"Thread B: {_field}");
        //        }   
        //    }).Start();

        //    Console.ReadKey();
        //}
    }
}
