/***************************************************************
 * 🔷 LeetCode 39. Combination Sum
 *
 * 🟡 Difficulty: Medium
 *
 * 📘 Problem:
 *   Given an array of distinct integers candidates and a target integer target,
 *   return a list of all unique combinations of candidates where the chosen numbers
 *   sum to target. You may return the combinations in any order.
 *
 *   The same number may be chosen from candidates an unlimited number of times.
 *   Two combinations are unique if the frequency of at least one of the chosen
 *   numbers is different.
 *
 *   The test cases are generated such that the number of unique combinations that
 *   sum up to target is less than 150 combinations for the given input.
 *
 * 📥 Example 1:
 *   Input:  candidates = [2,3,6,7], target = 7
 *   Output: [[2,2,3], [7]]
 *
 * 📥 Example 2:
 *   Input:  candidates = [2,3,5], target = 8
 *   Output: [[2,2,2,2], [2,3,3], [3,5]]
 *
 * 📥 Example 3:
 *   Input:  candidates = [2], target = 1
 *   Output: []
 *
 * ✅ Constraints:
 *   - 1 <= candidates.length <= 30
 *   - 2 <= candidates[i] <= 40
 *   - All elements of candidates are distinct
 *   - 1 <= target <= 40
 *
 * 🚩 Topics:
 *   Array, Backtracking
 ***************************************************************/

using System.Diagnostics;

namespace Week7_Backtracking_Assign3;

public class CombinationSum_39
{
    private static void Main()
    {
        
    }
    
    public IList<IList<int>> CombinationSum(int[] candidates, int target) 
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