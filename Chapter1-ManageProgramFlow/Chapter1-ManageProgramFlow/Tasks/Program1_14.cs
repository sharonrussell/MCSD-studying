﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1_ManageProgramFlow
{
    // all 3 tasks executed simultaneously, and takes 1000ms vs 3000ms
    public static class Program1_14
    {
        //public static void Main()
        //{
        //    var tasks = new Task[3];

        //    tasks[0] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine(1);
        //        return 1;
        //    });

        //    tasks[1] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine(2);
        //        return 2;
        //    });

        //    tasks[2] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine(3);
        //        return 3;
        //    });

        //    Task.WaitAll(tasks);
        //}
    }
}