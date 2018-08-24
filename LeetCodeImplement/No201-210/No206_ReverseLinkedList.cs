using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeImplement
{
    /// <summary>
    /// Reverse a singly linked list.
    /// Example:
    /// Input: 1->2->3->4->5->NULL
    /// Output: 5->4->3->2->1->NULL
    /// </summary>
    public class No206_ReverseLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        // 遞迴
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode tail = ReverseList(head.next);
            head.next.next = head;
            // 無這行對中間的node無影響，但需指定這行才可使原本的head最終指向null
            head.next = null;
            return tail;
        }

        // 迭代
        //public ListNode ReverseList(ListNode head)
        //{
        //    if (head == null || head.next == null)
        //        return head;

        //    ListNode curr = head;
        //    ListNode pre = null;
        //    ListNode next = curr.next;
        //    head.next = null;
        //    while (next.next != null)
        //    {
        //        pre = curr;
        //        curr = next;
        //        next = next.next;
        //        curr.next = pre;
        //    }
        //    next.next = curr;
        //    return next;
        //}
    }

}
