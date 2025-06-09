/***************************************************************
 * 🔷 LeetCode 3. Longest Substring Without Repeating Characters
 *                                                              
 * 🟠 Difficulty: Medium                                        
 *                                                              
 * 📘 Problem:                                                  
 *   Given a string `s`, find the length of the longest         
 *   substring without repeating characters.                    
 *                                                              
 *   A substring is a contiguous sequence of characters,        
 *   unlike a subsequence.                                      
 *                                                              
 * 📥 Example 1:                                                 
 *   Input:  s = "abcabcbb"                                     
 *   Output: 3                                                  
 *   Explanation: The answer is "abc", with length 3.           
 *                                                              
 * 📥 Example 2:                                                 
 *   Input:  s = "bbbbb"                                        
 *   Output: 1                                                  
 *   Explanation: The answer is "b".                            
 *                                                              
 * 📥 Example 3:                                                 
 *   Input:  s = "pwwkew"                                       
 *   Output: 3                                                  
 *   Explanation: The answer is "wke", with length 3.           
 *                "pwke" is not valid because it's not a       
 *                contiguous substring.                         
 ***************************************************************/

using System.Diagnostics;

namespace Week2_TwoPtrSlideWin_Assign2;

class LongestSubstringWithoutRepeatingCharacters_3
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