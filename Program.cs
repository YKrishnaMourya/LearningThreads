// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Diagnostics;
using System.Threading;
using System.Data;

void AsynchronusDownload(string fileName)
{
    
        Console.WriteLine($"Started Downloading {fileName}");
        Thread.Sleep(3000);
        Console.WriteLine($"Completed Downloading {fileName}");
}

List<string> fileNames = new() {
    "file One",
    "file Two",
    "file Three",
};

fileNames.ForEach(fileName => ThreadPool.QueueUserWorkItem((state) => AsynchronusDownload(fileName)));

Console.ReadLine();