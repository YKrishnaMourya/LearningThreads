// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Diagnostics;
using System.Threading;
using System.Data;

static void AsynchronusDownload(string fileName)
{
    
        Console.WriteLine($"Started Downloading {fileName}");
        Thread.Sleep(3000);
        Console.WriteLine($"Completed Downloading {fileName}");
}

// List<string> fileNames = new() {
//     "file One",
//     "file Two",
//     "file Three",
// };
var watch = Stopwatch.StartNew();


var taskOne = new Task(() => AsynchronusDownload("File One"));
var taskTwo = new Task(() => AsynchronusDownload("File Two"));

taskOne.Start();
taskTwo.Start();


watch.Stop();
Console.WriteLine($"It took {watch.Elapsed.Seconds} second(s) to complete.");



