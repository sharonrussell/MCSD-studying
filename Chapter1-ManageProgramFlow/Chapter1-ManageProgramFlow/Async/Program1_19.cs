using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1_ManageProgramFlow
{
    // A uses a thread from the thread pool while sleeping
    // B does not occupy a thread while waiting for timer to run (scalability)
    public static class Program1_19
    {
        public static Task SleepAsyncA(int millisecondsTimeout)
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }

        public static Task SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> taskCompletionSource = null;
            var t = new Timer(delegate
            {
                taskCompletionSource.TrySetResult(true);
            }, null, -1, -1);

            taskCompletionSource = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return taskCompletionSource.Task;
        }
    }
}