/***************************************************************
 * 🔷 LeetCode 735. Asteroid Collision
 *
 * 🟡 Difficulty: Medium
 *
 * 📘 Problem:
 *   We are given an array `asteroids` of integers representing 
 *   asteroids in a row. The index represents their position in space.
 *
 *   - The **absolute value** of each asteroid represents its **size**.
 *   - The **sign** represents its **direction**:
 *     - Positive ➡️: moving to the right
 *     - Negative ⬅️: moving to the left
 *
 *   All asteroids move at the same speed.
 *
 *   When two asteroids collide:
 *   - The smaller one explodes.
 *   - If they are the same size, both explode.
 *   - Asteroids moving in the same direction will **never** meet.
 *
 *   Return the state of the asteroids after all collisions.
 *
 * 📥 Example 1:
 *   Input:  asteroids = [5,10,-5]
 *   Output: [5,10]
 *   Explanation: 10 and -5 collide → 10 survives. 5 and 10 never collide.
 *
 * 📥 Example 2:
 *   Input:  asteroids = [8,-8]
 *   Output: []
 *   Explanation: Same size → both explode.
 *
 * 📥 Example 3:
 *   Input:  asteroids = [10,2,-5]
 *   Output: [10]
 *   Explanation:
 *     - 2 and -5 collide → -5 survives
 *     - 10 and -5 collide → 10 survives
 *
 * 🚩 Topic:
 *   Array, Stack, Simulation
 ***************************************************************/

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