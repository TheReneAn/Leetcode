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
        int[] steroidsCase1 = [5, 10, -5];
        int[] steroidsCase2 = [8, -8];
        int[] steroidsCase3 = [10, 2, -5];
        
        MeasureExecutionTime(() =>
        {
            var result1 = AsteroidCollision(steroidsCase1);
            Console.WriteLine($"Output: [{string.Join(", ", result1)}]");
        });
        
        var result2 = AsteroidCollision(steroidsCase2);
        Console.WriteLine($"Output: [{string.Join(", ", result2)}]");
        
        var result3 = AsteroidCollision(steroidsCase3);
        Console.WriteLine($"Output: [{string.Join(", ", result3)}]");
    }
    
    /// <summary>
    /// Returns the state of the asteroids after all collisions.
    /// </summary>
    /// <param name="asteroids">An array of integers representing asteroids.</param>
    /// <returns>The state of the asteroids after all collisions.</returns>
    private static int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();

        foreach (var currentAsteroid in asteroids)
        {
            var survived = true;

            while (stack.Count > 0 && currentAsteroid < 0 && stack.Peek() > 0)
            {
                var lastAsteroid = stack.Peek();
                var currentSize = Math.Abs(currentAsteroid);

                if (currentSize > lastAsteroid)
                {
                    stack.Pop(); // The asteroid on the stack explodes
                    continue;    // The current asteroid keeps moving and checks for more collisions
                }

                survived = false; // The current asteroid is destroyed

                // If both asteroids are the same size, both are destroyed
                if (currentSize == lastAsteroid)
                {
                    stack.Pop();
                }
                break; // No need to check for further collisions
            }

            // If the current asteroid survived all collisions, add it to the stack
            if (survived)
            {
                stack.Push(currentAsteroid);
            }
        }

        // The stack contains the result in reverse order, so reverse it before returning
        return stack.Reverse().ToArray();
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
 * 🔎 Interview Questions for LeetCode 735. Asteroid Collision
 *
 * 1️⃣ What data structure is best suited for this problem and why?
 *     → Stack is ideal because it allows us to keep track of previous asteroids 
 *       and resolve collisions in the correct order (LIFO).
 *
 * 2️⃣ When does a collision happen between two asteroids?
 *     → A collision only occurs when a right-moving asteroid (positive) 
 *       is followed by a left-moving asteroid (negative). 
 *       Asteroids moving in the same direction will never meet.
 *
 * 3️⃣ What is the time and space complexity?
 *     → Time: O(n), where n is the number of asteroids. Each asteroid is pushed 
 *       and popped at most once.
 *     → Space: O(n), for the stack used to store surviving asteroids.
 *
 * 4️⃣ How do you handle the case where asteroids are equal in size?
 *     → Both are destroyed, so we pop the last one from the stack 
 *       and do not push the current one.
 *
 * 5️⃣ Can this be solved without a stack?
 *     → Yes, technically — by using a list and simulating a stack behavior, 
 *       but a stack provides a cleaner and more idiomatic solution.
 *
 * 6️⃣ What are some important edge cases?
 *     → - All asteroids are moving in one direction (no collisions).
 *       - Multiple sequential collisions (e.g., [10, 2, -5]).
 *       - Asteroids of equal size meeting head-on.
 *
 * 7️⃣ What would change if asteroids had variable speeds?
 *     → The current solution assumes equal speeds. With different speeds, 
 *       we would need to simulate positions over time — likely needing 
 *       a priority queue or event-based simulation.
 ***************************************************************/