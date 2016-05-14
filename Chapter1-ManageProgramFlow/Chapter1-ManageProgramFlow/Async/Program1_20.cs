using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;

namespace Chapter1_ManageProgramFlow
{
    // this throws an exception, Output.Content is not executed on the UI
    // thread because of ConfigureAwait(false)
    // if you do something else, you don't need the SynchronizationContext
    // to be set
    public static class Program1_20
    {
        //public async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    HttpClient httpClient = new HttpClient();
        //    var content = await httpClient
        //        .GetStringAsync("http://www.microsoft.com")
        //        .ConfigureAwait(false);

        //    Output.Content = content;
        //}
    }

    // both awaits use ConfigureAwait(false) because if first method is already finished
    // before awaiter checks, code still runs on UI thread
}