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
        Console.WriteLine("[ValidPalindrome_125]");

        string[] testCases = {
            "A man, a plan, a canal: Panama",  // true
            "race a car",                      // false
            " ",                               // true
            "No 'x' in Nixon",                 // true
            "Was it a car or a cat I saw?"     // true
        };

        MeasureExecutionTime(() =>
        {
            for (var i = 0; i < testCases.Length; i++)
            {
                var input = testCases[i];
                var result = IsPalindrome(input);
                Console.WriteLine($"Test Case {i + 1}: \"{input}\" → {result}");
            }
        });
    }
    
    private static bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            // Skip non-alphanumeric characters on the left
            while (left < right && char.IsLetterOrDigit(s[left]) == false)
            {
                left++;
            }

            // Skip non-alphanumeric characters on the right
            while (left < right && char.IsLetterOrDigit(s[right]) == false)
            {
                right--;
            }

            // Compare characters after converting to lowercase
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
    
    private static void MeasureExecutionTime(Action action)
    {
        var stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();
        Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} ms\n");
    }
}