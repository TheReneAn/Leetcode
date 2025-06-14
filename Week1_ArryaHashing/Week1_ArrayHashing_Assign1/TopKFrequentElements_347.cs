/***************************************************************
 * 🔷 LeetCode 347. Top K Frequent Elements                     
 *                                                              
 * 🟠 Difficulty: Medium                                        
 *                                                              
 * 📘 Problem:                                                  
 *   Given an integer array `nums` and an integer `k`,          
 *   return the `k` most frequent elements. You may return      
 *   the answer in any order.                                   
 *                                                              
 * 📥 Example 1:                                                
 *   Input:  nums = [1,1,1,2,2,3], k = 2                         
 *   Output: [1,2]                                               
 *                                                              
 * 📥 Example 2:                                                
 *   Input:  nums = [1], k = 1                                   
 *   Output: [1]                                                
 * 
 * 🚩 Topic:
 *	 Array, Hash Table, Divide and Conquer, Sorting,Heap (Priority Queue),
 *	 Bucket Sort, Counting, Quickselect
 ***************************************************************/

using System.Diagnostics;

namespace Week1_ArrayHashing;

public class TopKFrequentElements_347
{
    static void Main(string[] args)
    {
        // Example test cases
        var num1 = new[] { 1, 1, 1, 2, 2, 3 };
        int[] num2 = [1];

        Console.WriteLine("[TopKFrequentElements_347]");

        // Answer_1
        MeasureExecutionTime(() =>
        {
            Console.WriteLine("Answer 1:");
            var resultNum1 = Answer1_TopKFrequent(num1, 2); // Expected output: [1, 2]
            var resultNum2 = Answer1_TopKFrequent(num2, 1); // Expected output: [1]
            Console.WriteLine(string.Join(", ", resultNum1));
            Console.WriteLine(string.Join(", ", resultNum2));
        });

        // Answer_2
        MeasureExecutionTime(() =>
        {
            Console.WriteLine("Answer 2:");
            var resultNum3 = Answer2_TopKFrequent(num1, 2);
            var resultNum4 = Answer2_TopKFrequent(num2, 1);
            Console.WriteLine(string.Join(", ", resultNum3));
            Console.WriteLine(string.Join(", ", resultNum4));
        });
    }

    /********** Method to find the k most frequent elements in the array **********/
    private static int[] Answer2_TopKFrequent(int[] nums, int k)
    {
        // Dictionary to count the frequency of each number
        var countMap = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            countMap[num] = countMap.GetValueOrDefault(num, 0) + 1;
        }

        // Min-Heap to keep track of the top k frequent elements
        var minHeap = new PriorityQueue<int, int>(); // element = number, priority = frequency

        foreach (var entry in countMap)
        {
            // Add the number with its frequency as priority
            minHeap.Enqueue(entry.Key, entry.Value);

            // If the heap exceeds size k, remove the element with the smallest frequency
            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        // Extract the top k elements from the heap and store them in the result array
        var result = new int[k];
        for (var i = k - 1; i >= 0; i--)
        {
            result[i] = minHeap.Dequeue();
        }

        // Return the top k frequent elements
        return result;
    }

    static int[] Answer1_TopKFrequent(int[] nums, int k)
    {
        // Dictionary to count the frequency of each element
        var frequentCountList = new Dictionary<int, int>();

        foreach (var item in nums)
        {
            // Increment count if exists, otherwise initialize to 1
            if (frequentCountList.ContainsKey(item))
            {
                frequentCountList[item]++;
            }
            else
            {
                frequentCountList[item] = 1;
            }
        }

        // Result array to store top k frequent elements
        var frequentElementList = new int[k];

        for (var i = 0; i < k; i++)
        {
            int maxKey = default;
            var maxCount = -1;

            // Find the element with the highest frequency
            foreach (var pair in frequentCountList)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    maxKey = pair.Key;
                }
            }

            // Store the element and remove it from the dictionary to avoid reuse
            frequentElementList[i] = maxKey;
            frequentCountList.Remove(maxKey);
        }

        return frequentElementList;
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
 * 🔎 Interview Questions for LeetCode 347. Top K Frequent Elements
 *
 * 1️⃣ What is the time and space complexity?
 *     → Time: O(n log k), where n is the number of elements and k is the number of results.
 *     → Space: O(n) for frequency map and heap.
 *
 * 2️⃣ Why use a min-heap instead of sorting?
 *     → Sorting takes O(n log n), but a heap lets us maintain only the top k elements,
 *        making the solution more efficient for large datasets.
 *
 * 3️⃣ Why is `if (heap.Count > k)` necessary?
 *     → To ensure that the heap only stores the k most frequent elements.
 *        We remove the least frequent one when we exceed k.
 *
 * 4️⃣ Can we use a max-heap instead?
 *     → Yes, but we would need to reverse the frequency comparison or use a custom comparator.
 *        In C#, min-heap is default so we use frequency as the priority directly.
 *
 * 5️⃣ What edge cases should we consider?
 *     → When all elements are unique, or when all elements are the same.
 *        Also, k == 1 or k == nums.Length.
 ***************************************************************/