/***************************************************************
 * 🔷 LeetCode 543. Diameter of Binary Tree
 *
 * 🟢 Difficulty: Easy
 *
 * 📘 Problem:
 *   Given the root of a binary tree, return the length of the diameter of the tree.
 *
 *   The diameter of a binary tree is the length of the longest path between
 *   any two nodes in a tree. This path may or may not pass through the root.
 *
 *   The length of a path between two nodes is represented by the number of edges between them.
 *
 * 📥 Example 1:
 *   Input: root = [1,2,3,4,5]
 *   Output: 3
 *   Explanation: 3 is the length of the path [4,2,1,3] or [5,2,1,3].
 *
 * 📥 Example 2:
 *   Input: root = [1,2]
 *   Output: 1
 *
 * ✅ Constraints:
 *   - The number of nodes in the tree is in the range [1, 10⁴].
 *   - -100 <= Node.val <= 100
 *
 * 🚩 Topics:
 *   Tree, Depth-First Search, Binary Tree
 ***************************************************************/

using System.Diagnostics;

namespace Week6_Trees_Assign3;

public class DiameterOfBinaryTree_543
{
    private static void Main()
    {

    }
    
    public int DiameterOfBinaryTree(TreeNode root)
    {
        return 0;
    }
    
    /// <summary>
    /// Definition for a binary tree node
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
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