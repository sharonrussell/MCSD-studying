using System.ComponentModel;

namespace Chapter1_ManageProgramFlow
{
    // configure when different continuation tasks will run
    public static class Program1_11
    {
        //public static void Main()
        //{
        //    var t = Task.Run(() => 42);

        //    t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Cancelled");
        //    }, TaskContinuationOptions.OnlyOnCanceled);

        //    t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Faulted");
        //    }, TaskContinuationOptions.OnlyOnFaulted);

        //    var completedTask = t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Completed");
        //    }, TaskContinuationOptions.OnlyOnRanToCompletion);

        //    completedTask.Wait();
        //}
    }
}