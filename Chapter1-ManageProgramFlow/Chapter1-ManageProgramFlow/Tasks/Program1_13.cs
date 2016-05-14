using System;
using System.Threading.Tasks;

namespace Chapter1_ManageProgramFlow
{
    // using a task factory to create tasks with the same options
    public static class Program1_13
    {
        //public static void Main()
        //{
        //    var parent = Task.Run(() =>
        //    {
        //        var results = new int[3];

        //        var taskFactory = new TaskFactory(TaskCreationOptions.AttachedToParent,
        //            TaskContinuationOptions.ExecuteSynchronously);

        //        taskFactory.StartNew(() => results[0] = 0);
        //        taskFactory.StartNew(() => results[1] = 1);
        //        taskFactory.StartNew(() => results[2] = 2);

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