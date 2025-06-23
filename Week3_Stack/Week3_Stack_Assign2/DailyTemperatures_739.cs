/***************************************************************
 * 🔷 LeetCode 739. Daily Temperatures
 *
 * 🟡 Difficulty: Medium
 *
 * 📘 Problem:
 *   Given an array of integers `temperatures` representing 
 *   the daily temperatures, return an array `answer` such that 
 *   `answer[i]` is the number of days you have to wait after 
 *   the `i-th` day to get a warmer temperature.
 * 
 *   If there is no future day for which this is possible, 
 *   keep `answer[i] == 0` instead.
 *
 * 📥 Example 1:
 *   Input:  temperatures = [73,74,75,71,69,72,76,73]
 *   Output: [1,1,4,2,1,1,0,0]
 *
 * 📥 Example 2:
 *   Input:  temperatures = [30,40,50,60]
 *   Output: [1,1,1,0]
 *
 * 📥 Example 3:
 *   Input:  temperatures = [30,60,90]
 *   Output: [1,1,0]
 *
 * 🚩 Topic:
 *   Array, Stack, Monotonic Stack
 ***************************************************************/

using System.Diagnostics;

namespace Week3_Stack_Assign2;

class DailyTemperatures_739
{
    static void Main(string[] args)
    {
        int[] temperaturesCase1 = [73, 74, 75, 71, 69, 72, 76, 73];
        int[] temperaturesCase2 = [30, 40, 50, 60];
        int[] temperaturesCase3 = [30, 60, 90];
        
        MeasureExecutionTime(() =>
        {
            var answer1 = DailyTemperatures(temperaturesCase1);
            Console.WriteLine(string.Join(", ", answer1));
        });
        
        var answer2 = DailyTemperatures(temperaturesCase2);
        Console.WriteLine(string.Join(", ", answer2));
        var answer3 = DailyTemperatures(temperaturesCase3);
        Console.WriteLine(string.Join(", ", answer3));
    }
    
    private static int[] DailyTemperatures(int[] temperatures) 
    {
        // Stack to stores indices
        var stack = new Stack<int>(); 
        var answer = new int[temperatures.Length];

        for (var i = 0; i < temperatures.Length; i++) 
        {
            // Check if the current temperature is higher than the one at the top of the stack
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) 
            {
                var prevIndex = stack.Pop();
                answer[prevIndex] = i - prevIndex; // How many days to wait
            }
            
            stack.Push(i); // Push current day's index
        }

        return answer;
    }
    
    private static void MeasureExecutionTime(Action action)
    {
        var stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();
        Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} ms\n");
    }
}

/***************************************************************
 * 🔎 Interview Questions for LeetCode 739. Daily Temperatures
 *
 * 1️⃣ What is the time and space complexity?
 *     → Time: O(n), Space: O(n)
 *       Each temperature is pushed and popped from the stack at most once.
 *
 * 2️⃣ Why use a stack in this problem?
 *     → To track the indices of unresolved temperatures in a **monotonic decreasing stack**.
 *       It helps us find the next warmer day in O(1) amortized time.
 *
 * 3️⃣ What kind of stack is used here?
 *     → A **monotonic stack** (specifically, decreasing),
 *       meaning temperatures in the stack are in descending order.
 *       We pop from the stack when a warmer temperature is found.
 *
 * 4️⃣ What do we store in the stack — values or indices?
 *     → We store **indices**, not actual temperature values,
 *       so we can calculate the number of days to wait using index difference.
 *
 * 5️⃣ What happens if no warmer day is found for a given day?
 *     → We leave `answer[i]` as the default `0`.
 *       This is correct per problem description.
 *
 * 6️⃣ Can we solve this problem with brute force?
 *     → Yes, but it would take O(n²) time by checking every future day,
 *       which is inefficient for large inputs.
 *
 * 7️⃣ What is a real-world analogy for this problem?
 *     → Like recording each day's temperature and waiting to see when it gets warmer,
 *       only resolving it once a warmer day actually arrives.
 *
 * 8️⃣ How would you modify the algorithm to return the actual temperature,
 *     not just the number of days?
 *     → Instead of `answer[prevIndex] = i - prevIndex;`,
 *       set `answer[prevIndex] = temperatures[i];`
 ***************************************************************/