namespace Chapter1_ManageProgramFlow
{
    // when breaking the parallel loop, result var has an IsCompleted
    // value of false and LowestBreakIteration of 500.
    // when you use stop, LowestBreakIteration is null.
    public static class Program1_17
    {
        //public static void Main()
        //{
        //    Parallel.For(0, 1000, (i, loopState) =>
        //    {
        //        if (i != 500) return;
        //        Console.WriteLine("Breaking loop");
        //        loopState.Break();
        //    });
        //}
    }
}