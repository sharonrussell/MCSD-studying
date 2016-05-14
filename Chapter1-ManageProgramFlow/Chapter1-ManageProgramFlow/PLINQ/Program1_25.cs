using System;
using System.Linq;

namespace Chapter1_ManageProgramFlow.PLINQ
{
    public static class Program1_25
    {
        // use as sequential to ensure that take method doesn't
        // mess up the order.
        //public static void Main()
        //{
        //    var numbers = Enumerable.Range(0, 10);
        //    var parallelResult = numbers.AsParallel()
        //        .Where(i => i%2 == 0).AsSequential();

        //    foreach (var i in parallelResult.Take(5))
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}