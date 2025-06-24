/***************************************************************
 * 🔷 LeetCode 33. Search in Rotated Sorted Array
 *
 * 🟡 Difficulty: Medium
 *
 * 📘 Problem:
 *   You are given a sorted array `nums` (ascending order, unique values),
 *   but it may have been rotated at an unknown pivot.
 *
 *   Your task is to find the index of a given `target` value.
 *   If the target is not found, return -1.
 *
 *   You must implement the search with O(log n) time complexity.
 *
 * 📌 Rotation Example:
 *   Original: [0,1,2,4,5,6,7]
 *   Rotated : [4,5,6,7,0,1,2]  ← rotated at index 3
 *
 * 📥 Example 1:
 *   Input:  nums = [4,5,6,7,0,1,2], target = 0
 *   Output: 4
 *
 * 📥 Example 2:
 *   Input:  nums = [4,5,6,7,0,1,2], target = 3
 *   Output: -1
 *
 * 📥 Example 3:
 *   Input:  nums = [1], target = 0
 *   Output: -1
 *
 * ✅ Constraints:
 *   - 1 <= nums.length <= 5000
 *   - -10⁴ <= nums[i], target <= 10⁴
 *   - All elements are unique
 *   - nums is sorted in ascending order and possibly rotated
 *
 * 🚩 Topics:
 *   Array, Binary Search
 ***************************************************************/

using System.Diagnostics;

namespace Week4_BinarySearch_Assign2;

public class SearchInRotatedSortedArray_33
{
    static void Main(string[] args)
    {
        int[] numsCase1 = [4, 5, 6, 7, 0, 1, 2];
        int[] numsCase2 = [1];
        
        MeasureExecutionTime(() =>
        {
            var result1 = Search(numsCase1, 0);
            Console.WriteLine(result1);
        });
        
        var result2 = Search(numsCase1, 3);
        Console.WriteLine(result2);
        
        var result3 = Search(numsCase2, 0);
        Console.WriteLine(result3);
    }
    
    private static int Search(int[] nums, int target)
    {
        var result = 0;
        return result;
    }
    
    private static void MeasureExecutionTime(Action action)
    {
        var stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();
        Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} ms\n");
    }
}