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
        var tree = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(5)
            ),
            new TreeNode(3)
        );

        var solution = new DiameterOfBinaryTree_543();

        MeasureExecutionTime(() =>
        {
            int result = solution.DiameterOfBinaryTree(tree);
            Console.WriteLine($"Diameter of Binary Tree: {result}");
        });
    }
    
    private int _maxDiameter; // Tracks the maximum diameter found

    public int DiameterOfBinaryTree(TreeNode root)
    {
        // Start DFS traversal to calculate diameter
        Depth(root);
        return _maxDiameter;
    }

    // Helper function that returns the height of the current node
    private int Depth(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        var left = Depth(node.left);   // Height of left subtree
        var right = Depth(node.right); // Height of right subtree

        // Diameter at current node = left height + right height
        _maxDiameter = Math.Max(_maxDiameter, left + right);

        // Return height of this node
        return Math.Max(left, right) + 1;
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