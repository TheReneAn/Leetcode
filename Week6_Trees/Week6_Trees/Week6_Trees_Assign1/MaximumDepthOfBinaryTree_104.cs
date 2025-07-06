﻿/***************************************************************
 * 🔷 LeetCode 104. Maximum Depth of Binary Tree
 *
 * 🟢 Difficulty: Easy
 *
 * 📘 Problem:
 *   Given the root of a binary tree, return its maximum depth.
 *
 *   A binary tree's maximum depth is the number of nodes along
 *   the longest path from the root node down to the farthest leaf node.
 *
 * 📥 Example 1:
 *   Input:  root = [3,9,20,null,null,15,7]
 *   Output: 3
 *
 * 📥 Example 2:
 *   Input:  root = [1,null,2]
 *   Output: 2
 *
 * ✅ Constraints:
 *   - The number of nodes in the tree is in the range [0, 10⁴].
 *   - -100 <= Node.val <= 100
 *
 * 🚩 Topics:
 *   Tree, Depth-First Search, Breadth-First Search, Binary Tree
 ***************************************************************/

using System.Diagnostics;

namespace Week6_Trees_Assign1;

public class MaximumDepthOfBinaryTree_104
{
    private static void Main()
    {

    }

    public int MaxDepth(TreeNode root)
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