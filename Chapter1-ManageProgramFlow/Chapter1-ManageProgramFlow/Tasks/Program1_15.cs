using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1_ManageProgramFlow
{
    //using wait any and then removing that task from the list of
    // tasks once complete
    public static class Program1_15
    {
        //public static void Main()
        //{
        //    var tasks = new Task<int>[3];

        //    tasks[0] = Task.Run(() =>
        //    {
        //        Thread.Sleep(2000);
        //        return 1;
        //    });

        //    tasks[0] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        return 2;
        //    });

        //    tasks[0] = Task.Run(() =>
        //    {
        //        Thread.Sleep(3000);
        //        return 3;
        //    });

        //    while (tasks.Length > 0)
        //    {
        //        var i = Task.WaitAny(tasks);
        //        var completedTask = tasks[i];

        //        Console.WriteLine(completedTask.Result);

        //        var temp = tasks.ToList();
        //        temp.RemoveAt(i);
        //        tasks = temp.ToArray();
        //    }
        //}
    }
}