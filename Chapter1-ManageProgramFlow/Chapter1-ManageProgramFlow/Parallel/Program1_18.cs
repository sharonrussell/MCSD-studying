using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter1_ManageProgramFlow
{
    // accesses the result property in the main method
    // which blocks the code until DownloadContent is finished
    public static class Program1_18
    {
        //public static void Main()
        //{
        //    var result = DownloadContent().Result;
        //    Console.WriteLine(result);
        //}

        private static async Task<string> DownloadContent()
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync("http://www.microsoft.com");
            }
        }
    }
}