/***************************************************************
 * 🔷 LeetCode 125. Valid Palindrome
 *
 * 🟢 Difficulty: Easy
 *
 * 📘 Problem:
 *   A phrase is a palindrome if, after converting all uppercase
 *   letters into lowercase and removing all non-alphanumeric
 *   characters, it reads the same forward and backward.
 *
 *   Alphanumeric characters include letters and numbers.
 *
 *   Given a string `s`, return true if it is a palindrome, or
 *   false otherwise.
 *
 * 📥 Example 1:
 *   Input:  s = "A man, a plan, a canal: Panama"
 *   Output: true
 *   Explanation: "amanaplanacanalpanama" is a palindrome.
 *
 * 📥 Example 2:
 *   Input:  s = "race a car"
 *   Output: false
 *   Explanation: "raceacar" is not a palindrome.
 *
 * 📥 Example 3:
 *   Input:  s = " "
 *   Output: true
 *   Explanation: An empty string is considered a palindrome.
 ***************************************************************/

using System.Diagnostics;

namespace Week2_TwoPtrSlideWin;

class ValidPalindrome_125
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