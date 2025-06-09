/***************************************************************
 * 🔷 LeetCode 424. Longest Repeating Character Replacement     
 *                                                              
 * 🟠 Difficulty: Medium                                        
 *                                                              
 * 📘 Problem:                                                  
 *   You are given a string `s` and an integer `k`.             
 *   You can change any character in the string to any other    
 *   uppercase English letter, at most `k` times.               
 *                                                              
 *   Return the length of the longest substring containing      
 *   the same letter after performing up to `k` replacements.   
 *                                                              
 * 📥 Example 1:                                                 
 *   Input:  s = "ABAB", k = 2                                  
 *   Output: 4                                                  
 *   Explanation: Replace two 'A's with 'B's (or vice versa),   
 *                result: "BBBB" or "AAAA".                     
 *                                                              
 * 📥 Example 2:                                                 
 *   Input:  s = "AABABBA", k = 1                                
 *   Output: 4                                                  
 *   Explanation: Replace the middle 'A' with 'B',              
 *                result: "AABBBBA" → "BBBB" has length 4.      
 *                Other valid transformations may exist.        
 ***************************************************************/

using System.Diagnostics;

namespace Week2_TwoPtrSlideWin_Assign3;

class LongestRepeatingCharacterReplacement_424
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    private static void MeasureExecutionTime(Action action)
    {
        var stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();
        Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} ms\n");
    }
}