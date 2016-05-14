using System;
using System.Linq;

namespace Chapter1_ManageProgramFlow.PLINQ
{
    // catching all aggregate exceptions and looping through
    // inner exceptions
    public static class Program1_27
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 20);

            try
            {
                var parallelResult = numbers.AsParallel()
                    .Where(IsEven);
                    
                parallelResult.ForAll(Console.WriteLine);
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"there were {e.InnerExceptions.Count} exceptions");
            }
        }

        private static bool IsEven(int i)
        {
            if (i%10 == 0) throw new ArgumentException("i");
            return 1%2 == 0;
        }
    }
}