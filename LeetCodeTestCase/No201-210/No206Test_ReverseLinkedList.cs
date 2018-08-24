using System;
using System.Linq;
using LeetCodeImplement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTestCase
{
    /// <summary>
    /// Reverse a singly linked list.
    /// Example:
    /// Input: 1->2->3->4->5->NULL
    /// Output: 5->4->3->2->1->NULL
    /// </summary>
    [TestClass]
    public class No206Test_ReverseLinkedList
    {
        private No206_ReverseLinkedList solution;

        [TestInitialize]
        public void Init()
        {
            solution = new No206_ReverseLinkedList();
        }

        [TestMethod]
        public void NoNode()
        {
            No206_ReverseLinkedList.ListNode head = solution.ReverseList(null);
            Assert.IsNull(head);
        }

        [TestMethod]
        public void OneNode()
        {
            No206_ReverseLinkedList.ListNode node = new No206_ReverseLinkedList.ListNode(1);
            No206_ReverseLinkedList.ListNode reverseHead = solution.ReverseList(node);
            Assert.IsNotNull(reverseHead);
            Assert.AreEqual(1, reverseHead.val);
            Assert.IsNull(node.next);
        }

        [TestMethod]
        public void TwoNode_2_3_ReturnHead3_2()
        {
            No206_ReverseLinkedList.ListNode head = new No206_ReverseLinkedList.ListNode(2);
            No206_ReverseLinkedList.ListNode node = new No206_ReverseLinkedList.ListNode(3);
            head.next = node;
            No206_ReverseLinkedList.ListNode reverseHead = solution.ReverseList(head);
            Assert.IsNotNull(reverseHead);
            Assert.AreEqual(3, reverseHead.val);
            Assert.AreEqual(2, reverseHead.next.val);
            Assert.IsNull(head.next);
        }

        [TestMethod]
        public void FourNode_2_3_4_5_ReturnHead5_4_3_2()
        {
            No206_ReverseLinkedList.ListNode head = new No206_ReverseLinkedList.ListNode(2);
            No206_ReverseLinkedList.ListNode node1 = new No206_ReverseLinkedList.ListNode(3);
            No206_ReverseLinkedList.ListNode node2 = new No206_ReverseLinkedList.ListNode(4);
            No206_ReverseLinkedList.ListNode node3 = new No206_ReverseLinkedList.ListNode(5);
            head.next = node1;
            head.next.next = node2;
            head.next.next.next = node3;
            No206_ReverseLinkedList.ListNode reverseHead = solution.ReverseList(head);
            Assert.IsNotNull(reverseHead);
            Assert.AreEqual(5, reverseHead.val);
            Assert.AreEqual(4, reverseHead.next.val);
            Assert.AreEqual(3, reverseHead.next.next.val);
            Assert.AreEqual(2, reverseHead.next.next.next.val);
            Assert.IsNull(head.next);
        }

        [TestMethod]
        public void FiveNode1_2_3_4_5_ReturnHead5_4_3_2_1()
        {
            No206_ReverseLinkedList.ListNode head = new No206_ReverseLinkedList.ListNode(1);
            No206_ReverseLinkedList.ListNode node1 = new No206_ReverseLinkedList.ListNode(2);
            No206_ReverseLinkedList.ListNode node2 = new No206_ReverseLinkedList.ListNode(3);
            No206_ReverseLinkedList.ListNode node3 = new No206_ReverseLinkedList.ListNode(4);
            No206_ReverseLinkedList.ListNode node4 = new No206_ReverseLinkedList.ListNode(5);
            head.next = node1;
            head.next.next = node2;
            head.next.next.next = node3;
            head.next.next.next.next = node4;
            No206_ReverseLinkedList.ListNode reverseHead = solution.ReverseList(head);
            Assert.IsNotNull(reverseHead);
            Assert.AreEqual(5, reverseHead.val);
            Assert.AreEqual(4, reverseHead.next.val);
            Assert.AreEqual(3, reverseHead.next.next.val);
            Assert.AreEqual(2, reverseHead.next.next.next.val);
            Assert.AreEqual(1, reverseHead.next.next.next.next.val);
            Assert.IsNull(head.next);
        }
    }
}
