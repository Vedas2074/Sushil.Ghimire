using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelAsyncs
{
    class Program
    {
        static void Main()
        {
            //TPL- task parallel Library
            int[] numbers = {12,23,43,4,5,56,3,45,3,21 };
            Stopwatch stopwatch = new Stopwatch();
            //sequential 
            stopwatch.Start();
            foreach(var num in numbers)
            {
                Compute(num);
            }
            Console.WriteLine($"Time taken (sequential):{stopwatch.ElapsedMilliseconds}ms");
            //parallel
            stopwatch.Restart();
            Parallel.ForEach(numbers, num =>
            {
                Compute(num);
            });
            Console.WriteLine($"Time taken (Parallel):{stopwatch.ElapsedMilliseconds}ms");
        }
        static void Compute(int x)
        {
            Thread.Sleep(100);
            Console.WriteLine($"Computed for {x}");
        }
    }
}
