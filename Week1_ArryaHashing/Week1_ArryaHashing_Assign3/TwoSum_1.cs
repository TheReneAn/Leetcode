/***************************************************************
 * 🔷 LeetCode 1. Two Sum                                       
 *                                                              
 * 🟢 Difficulty: Easy                                          
 *                                                              
 * 📘 Problem:                                                  
 *   Given an array of integers `nums` and an integer `target`, 
 *   return indices of the two numbers such that they add up    
 *   to `target`.                                               
 *                                                              
 *   You may assume that each input would have exactly one      
 *   solution, and you may not use the same element twice.      
 *                                                              
 *   You can return the answer in any order.                    
 *                                                              
 * 📥 Example 1:                                                
 *   Input:  nums = [2,7,11,15], target = 9                     
 *   Output: [0,1]                                               
 *   Explanation: nums[0] + nums[1] == 9 → return [0, 1]        
 *                                                              
 * 📥 Example 2:                                                
 *   Input:  nums = [3,2,4], target = 6                         
 *   Output: [1,2]                                               
 *                                                              
 * 📥 Example 3:                                                
 *   Input:  nums = [3,3], target = 6                           
 *   Output: [0,1]                                               
 ***************************************************************/

using System.Diagnostics;

namespace Week1_ArrayHashing
{
    class TwoSum_1
    {
        static void Main(string[] args)
        {
            int[] nums1 = [2, 7, 11, 15];
            int[] nums2 = [3, 2, 4];
            int[] nums3 = [3, 3];
            
            Console.WriteLine("[TwoSum_1]");
            
            // Answer_1
            Console.WriteLine("Answer 1:");
            MeasureExecutionTime(() => {
                var result1 = Answer1_TwoSum(nums1, 9);
                var result2 = Answer1_TwoSum(nums2, 6);
                var result3 = Answer1_TwoSum(nums3, 6);
                Console.WriteLine(string.Join(", ", result1));
                Console.WriteLine(string.Join(", ", result2));
                Console.WriteLine(string.Join(", ", result3));
            });

            // Answer_2
            Console.WriteLine("Answer 2:");
            MeasureExecutionTime(() => {
                var result1 = Answer2_TwoSum(nums1, 9);
                var result2 = Answer2_TwoSum(nums2, 6);
                var result3 = Answer2_TwoSum(nums3, 6);
                Console.WriteLine(string.Join(", ", result1));
                Console.WriteLine(string.Join(", ", result2));
                Console.WriteLine(string.Join(", ", result3));
            });
        }

        private static int[] Answer2_TwoSum(int[] nums, int target)
        {
            // Dictionary to store numbers and their corresponding indices
            var map = new Dictionary<int, int>();

            // Iterate through the array once
            for (var i = 0; i < nums.Length; i++)
            {
                // Calculate the value needed to reach complement
                var complement = target - nums[i];

                // Check if the complement is already in the map
                if (map.ContainsKey(complement))
                {
                    // If found, return the index of the complement and the current index
                    return [map[complement], i];
                }

                // Otherwise, store the current number and its index in the map
                map[nums[i]] = i;
            }

            // If no solution is found, return an empty array
            return [];
        }

        private static int[] Answer1_TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            
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
}

/***************************************************************
 * 🔎 Interview Questions for LeetCode 1. Two Sum
 *
 * 1️⃣ What is the time and space complexity?
 *     → Time: O(n), Space: O(n) — We use a single pass with a hash map.
 *
 * 2️⃣ Why use a hash map?
 *     → To check if the complement exists in constant time (O(1)).
 *        It allows us to avoid nested loops and improves efficiency.
 *
 * 3️⃣ What if the array is sorted?
 *     → Use the two-pointer approach: start from both ends and move inward
 *        depending on the current sum compared to the target.
 *
 * 4️⃣ What if there are multiple correct pairs?
 *     → If multiple are allowed, we would collect all valid index pairs in a list.
 *
 * 5️⃣ What edge cases should be considered?
 *     → Same element used twice (e.g., [3,3]), negative numbers, duplicates,
 *        empty or very large arrays.
 *
 * 6️⃣ Why is `map[nums[i]] = i` placed after checking the complement?
 *     → To avoid using the same element twice (e.g., matching a number with itself).
 ***************************************************************/
