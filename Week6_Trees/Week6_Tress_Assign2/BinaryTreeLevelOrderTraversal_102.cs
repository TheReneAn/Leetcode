/***************************************************************
 * 🔷 LeetCode 102. Binary Tree Level Order Traversal
 *
 * 🟡 Difficulty: Medium
 *
 * 📘 Problem:
 *   Given the root of a binary tree, return the level order traversal
 *   of its nodes' values. (i.e., from left to right, level by level).
 *
 * 📥 Example 1:
 *   Input:  root = [3,9,20,null,null,15,7]
 *   Output: [[3],[9,20],[15,7]]
 *
 * 📥 Example 2:
 *   Input:  root = [1]
 *   Output: [[1]]
 *
 * 📥 Example 3:
 *   Input:  root = []
 *   Output: []
 *
 * ✅ Constraints:
 *   - The number of nodes in the tree is in the range [0, 2000].
 *   - -1000 <= Node.val <= 1000
 *
 * 🚩 Topics:
 *   Tree, Breadth-First Search, Binary Tree
 ***************************************************************/

using System.Diagnostics;

namespace Week6_Trees_Assign2;

public class BinaryTreeLevelOrderTraversal_102
{
    private static void Main()
    {

    }
    
    public IList<IList<int>> LevelOrder(TreeNode root) 
    {
        return LevelOrder(root.left);
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