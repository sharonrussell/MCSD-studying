using System;
using System.Threading.Tasks;

namespace Chapter1_ManageProgramFlow
{
    // final task only runs after parent task is finished
    // parent task finishes once all child tasks finished.
    public static class Program1_12
    {
        //public static void Main()
        //{
        //    var parent = Task.Run(() =>
        //    {
        //        var results = new int[3];

        //        new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();

        //        return results;
        //    });

        //    var finalTask = parent.ContinueWith(parentTask =>
        //    {
        //        foreach (var i in parentTask.Result)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    });

        //    finalTask.Wait();
        //}
    }
}