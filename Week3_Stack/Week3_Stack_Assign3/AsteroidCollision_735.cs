using System.Diagnostics;

namespace Week3_Stack_Assign3;

class AsteroidCollision_735
{
    static void Main(string[] args)
    {
        MeasureExecutionTime(() =>
        {
            
        });
    }
    
    private static void MeasureExecutionTime(Action action)
    {
        var stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();
        Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} ms\n");
    }
}