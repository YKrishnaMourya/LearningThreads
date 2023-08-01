// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Diagnostics;
using System.Threading;
using System.Data;

static string AsynchronusDownload(string fileName)
{
    var threadId = Thread.CurrentThread.ManagedThreadId;
    var threadPool = Thread.CurrentThread.IsThreadPoolThread;

    Console.WriteLine($"The thread #{threadId}, use a thread pool {threadPool}");
    Console.WriteLine($"Started Downloading {fileName}");
    Thread.Sleep(3000);
    return fileName;
}
var threadId = Thread.CurrentThread.ManagedThreadId;
var threadPool = Thread.CurrentThread.IsThreadPoolThread;

Console.WriteLine($"The thread #{threadId}, use a thread pool {threadPool}");
var result = "No Download";

var taskOne = Task.Run(() => AsynchronusDownload("File One"));

taskOne.ContinueWith((taskOne) =>
{

    var threadId = Thread.CurrentThread.ManagedThreadId;
    var threadPool = Thread.CurrentThread.IsThreadPoolThread;

    Console.WriteLine($"The thread #{threadId}, use a thread pool {threadPool}");
    result = taskOne.Result;
    Console.WriteLine($"Completed Downloading {result}");
});


while(result == "No Download")
{
    Thread.Sleep(1000);
    Console.WriteLine("Downloading");
}





