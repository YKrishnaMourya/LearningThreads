// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Diagnostics;
using System.Threading;
using System.Data;

static string AsynchronusDownload(string fileName)
{
    
        Console.WriteLine($"Started Downloading {fileName}");
        Thread.Sleep(3000);
        Console.WriteLine($"Completed Downloading {fileName}");
        return fileName;
}

// List<string> fileNames = new() {
//     "file One",
//     "file Two",
//     "file Three",
// };
var watch = Stopwatch.StartNew();


var taskOne = Task.Run(() => AsynchronusDownload("File One"));
Task<string> taskTwo = Task.Run(() => AsynchronusDownload("File Two"));


Thread.Sleep(3100);

watch.Stop();
Console.WriteLine($"Downloads: {taskOne.Result}, {taskTwo.Result}");
Console.WriteLine($"It took {watch.Elapsed.Seconds} second(s) to complete.");



