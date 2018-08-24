using System;
using System.Linq;
using LeetCodeImplement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTestCase
{
    /// <summary>
    /// Given a binary tree, find its maximum depth.
    /// The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    /// Note: A leaf is a node with no children.
    /// Example:
    /// Given binary tree[3, 9, 20, null, null, 15, 7],
    /// return its depth = 3.
    /// </summary>
    [TestClass]
    public class No104Test_MaximumDepthofBinaryTree
    {
        private No104_MaximumDepthofBinaryTree solution;

        [TestInitialize]
        public void Init()
        {
            solution = new No104_MaximumDepthofBinaryTree();
        }

        [TestMethod]
        public void OneNode_Return1()
        {
            No104_MaximumDepthofBinaryTree.TreeNode root = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            int depth = solution.MaxDepth(root);
            Assert.AreEqual(1, depth);
        }

        [TestMethod]
        public void RootHasLeftChild_Return2()
        {
            No104_MaximumDepthofBinaryTree.TreeNode root = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            root.left = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            int depth = solution.MaxDepth(root);
            Assert.AreEqual(2, depth);
        }

        [TestMethod]
        public void RootHasRightChild_Return2()
        {
            No104_MaximumDepthofBinaryTree.TreeNode root = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            root.right = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            int depth = solution.MaxDepth(root);
            Assert.AreEqual(2, depth);
        }

        [TestMethod]
        public void RootHasBothChild_Return2()
        {
            No104_MaximumDepthofBinaryTree.TreeNode root = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            root.left = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            root.right = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            int depth = solution.MaxDepth(root);
            Assert.AreEqual(2, depth);
        }

        [TestMethod]
        public void NoNode_Return0()
        {
            int depth = solution.MaxDepth(null);
            Assert.AreEqual(0, depth);
        }

        [TestMethod]
        public void Tree11101010010_Return4()
        {
            No104_MaximumDepthofBinaryTree.TreeNode root = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            root.left = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            root.right = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            root.left.right = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            root.right.right = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            root.left.right.left = new No104_MaximumDepthofBinaryTree.TreeNode(1);
            int depth = solution.MaxDepth(root);
            Assert.AreEqual(4, depth);
        }
    }
}
