// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Diagnostics;
using System.Threading;

void SampleWork(object? filename)
{
    if (filename != null) 
    {
        string message = (string)filename;
        Console.WriteLine($"Work Started {message}");
        Thread.Sleep(3000);
        Console.WriteLine("Work Done");
    }
}

var threadOne = new Thread(SampleWork);
var threadTwo = new Thread(SampleWork);
var watch = Stopwatch.StartNew();

threadOne.Start("Thread One");
threadTwo.Start("Thread Two");

threadOne.Join();
threadTwo.Join();

watch.Stop();

Console.WriteLine($"It took {watch.Elapsed.Seconds} second(s) to complete.");