﻿/***************************************************************
 * 🔷 LeetCode 49. Group Anagrams
 *
 * 🟠 Difficulty: Medium
 *
 * 📘 Problem:
 *   Given an array of strings `strs`, group the anagrams
 *   together. You can return the answer in any order.
 *
 * ✨ Definition:
 *   An anagram is a word formed by rearranging the letters
 *   of another word.
 *
 * 📥 Example 1:
 *   Input:  ["eat", "tea", "tan", "ate", "nat", "bat"]
 *   Output: [["bat"], ["nat","tan"], ["ate","eat","tea"]]
 *
 * 📥 Example 2:
 *   Input:  [""]
 *   Output: [[""]]
 *
 * 📥 Example 3:
 *   Input:  ["a"]
 *   Output: [["a"]]
 * 
 * 🚩 Topic:
 *	 Array, Hash Table, String, Sorting
 ***************************************************************/

using System.Diagnostics;

namespace Week1_ArrayHashing;

public class GroupAnagrams_49
{
    static void Main(string[] args)
    {
        var strs1 = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var strs2 = new[] { " " };
        var strs3 = new[] { "a" };

        Console.WriteLine("[GroupAnagrams_49]");
            
        // Answer_1
        Console.WriteLine("Answer 1:");
        MeasureExecutionTime(() =>
        {
            var resultAnswer1 = Answer1_GroupAnagrams(strs1);
            var resultAnswer2 = Answer1_GroupAnagrams(strs2);
            var resultAnswer3 = Answer1_GroupAnagrams(strs3);
            PrintResult(resultAnswer1);
            PrintResult(resultAnswer2);
            PrintResult(resultAnswer3);
        });

        // Answer_2
        Console.WriteLine("Answer 2:");
        MeasureExecutionTime(() =>
        {
            var resultAnswer1 = Answer2_GroupAnagrams(strs1);
            var resultAnswer2 = Answer2_GroupAnagrams(strs2);
            var resultAnswer3 = Answer2_GroupAnagrams(strs3);
            PrintResult(resultAnswer1);
            PrintResult(resultAnswer2);
            PrintResult(resultAnswer3);
        });
    }

    static IList<IList<string>> Answer2_GroupAnagrams(string[] strs)
    {
        // Dictionary to group words by their sorted character key
        var map = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            // Sort the string to use as key
            var charArray = str.ToCharArray(); // e.g., "eat" -> "aet"
            Array.Sort(charArray);
            var sorted = new string(charArray);

            // Group words by sorted string
            if (map.TryGetValue(sorted, out var group) == false)
            {
                group = new List<string>();
                map[sorted] = group;
            }

            // Add the word to its corresponding group
            group.Add(str);
        }

        // Convert Dictionary values to List<IList<string>>
        var result = new List<IList<string>>();
        foreach (var group in map.Values)
        {
            result.Add(group);
        }

        return result;
    }

    static IList<IList<string>> Answer1_GroupAnagrams(string[] strs) 
    {
        // Dictionary to group words by their sorted character key
        var map = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            // Sort the string to use as key
            var charArray  = str.ToCharArray();
            Array.Sort(charArray);
            var sorted = new string(charArray); // e.g., "eat" → "aet"

            // Group words by sorted string
            if (map.ContainsKey(sorted) == false)
            {
                // If not found, create a new group and add it to the dictionary
                map[sorted] = new List<string>();
            }

            // Add the word to its corresponding group
            map[sorted].Add(str);
        }

        // Convert Dictionary values to List<IList<string>>
        var result = new List<IList<string>>();
        foreach (var group in map.Values)
        {
            result.Add(group);
        }

        return result;
    }
        
    private static void PrintResult(IList<IList<string>> groups)
    {
        foreach (var group in groups)
        {
            Console.Write("[");
            Console.Write(string.Join(", ", group));
            Console.WriteLine("]");
        }
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
 * 🔎 Interview Questions for LeetCode 49. Group Anagrams
 *
 * 1️⃣ What is the time and space complexity?
 *     → Time: O(n * k log k), where n is the number of words and k is the average word length.
 *     → Space: O(n) for the hash map storing groups.
 *
 * 2️⃣ Why use the sorted string as a key?
 *     → Anagrams become the same string after sorting,
 *        so it’s a reliable way to group them efficiently.
 *
 * 3️⃣ Can we solve this without sorting the strings?
 *     → Yes, we can use a character frequency array (e.g., 26-length int array as key)
 *        instead of sorting — more optimal for longer strings.
 *
 * 4️⃣ What edge cases should we consider?
 *     → Empty string input, single-letter strings, or all strings being anagrams of each other.
 *
 * 5️⃣ Does the order of groups or words inside groups matter?
 *     → No. The problem states the answer can be in any order.
 ***************************************************************/