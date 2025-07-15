/***************************************************************
 * 🔷 LeetCode 46. Permutations
 *
 * 🟡 Difficulty: Medium
 *
 * 📘 Problem:
 *   Given an array `nums` of distinct integers, return all possible
 *   permutations. You can return the answer in any order.
 *
 * 📥 Example 1:
 *   Input:  nums = [1,2,3]
 *   Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
 *
 * 📥 Example 2:
 *   Input:  nums = [0,1]
 *   Output: [[0,1],[1,0]]
 *
 * 📥 Example 3:
 *   Input:  nums = [1]
 *   Output: [[1]]
 *
 * ✅ Constraints:
 *   - 1 <= nums.length <= 6
 *   - -10 <= nums[i] <= 10
 *   - All the integers of `nums` are unique.
 *
 * 🚩 Topics:
 *   Array, Backtracking
 ***************************************************************/

using System.Diagnostics;

namespace Week7_Backtracking_Assign2;

public class Subsets_78
{
    private static void Main()
    {
        
    }
    
    public IList<IList<int>> Permute(int[] nums) 
    {
        
    }
    
    private static void MeasureExecutionTime(Action action)
    {
        var stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();
        Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} ms\n");
    }
}