using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeImplement
{
    /// <summary>
    /// Given a binary tree, find its maximum depth.
    /// The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    /// Note: A leaf is a node with no children.
    /// Example:
    /// Given binary tree[3, 9, 20, null, null, 15, 7],
    /// return its depth = 3.
    /// </summary>
    public class No104_MaximumDepthofBinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            int maxDepthLeft = 0, maxDepthRight = 0;
            if (root.left != null)
                maxDepthLeft = 1 + MaxDepth(root.left);
            if (root.right != null)
                maxDepthRight = 1 + MaxDepth(root.right);
            if (maxDepthLeft > maxDepthRight)
                return maxDepthLeft;
            else
                return maxDepthRight;
        }

        //public int MaxDepth(TreeNode root)
        //{
        //    if (root.left == null && root.right == null)
        //        return 1;
        //    else
        //        throw new NotImplementedException();
        //}
    }

}
