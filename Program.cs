// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Diagnostics;
using System.Threading;

void SampleWork()
{
    Console.WriteLine("Work Started");
    Thread.Sleep(3000);
    Console.WriteLine("Work Done");
}

var watch = Stopwatch.StartNew();

SampleWork();
SampleWork();

watch.Stop();

Console.WriteLine($"It took {watch.Elapsed.Seconds} second(s) to complete.");