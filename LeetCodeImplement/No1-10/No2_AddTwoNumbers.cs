using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeImplement
{
    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers. 
    /// The digits are stored in reverse order and each of their nodes contain a single digit. 
    /// Add the two numbers and return it as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    /// Output: 7 -> 0 -> 8
    /// </summary>
    public class No2_AddTwoNumbers
    {
        /// <summary>
        /// Definition for singly-linked list.
        /// </summary>
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // first node of resultStartPoint is a start point(not real value)
            ListNode resultStartPoint = new ListNode(-1);
            ListNode resultPointer = resultStartPoint;
            ListNode firstNumPointer = l1;
            ListNode secondNumPointer = l2;
            // restore carry value
            int carryDigit = 0;

            // both input lists shouldn't be null(at least contain one node), so we use do..while
            do
            {
                int digitOfFirstNum = 0, digitOfSecondNum = 0;
                if (firstNumPointer != null)
                {
                    digitOfFirstNum = firstNumPointer.val;
                    firstNumPointer = firstNumPointer.next;
                }
                if (secondNumPointer != null)
                {
                    digitOfSecondNum = secondNumPointer.val;
                    secondNumPointer = secondNumPointer.next;
                }
                int thisDigitSum = digitOfFirstNum + digitOfSecondNum + carryDigit;
                resultPointer.next = new ListNode(thisDigitSum % 10);
                resultPointer = resultPointer.next;
                carryDigit = (thisDigitSum >= 10) ? 1 : 0;
            } while (firstNumPointer != null || secondNumPointer != null || carryDigit > 0);

            return resultStartPoint.next;
        }

        // Implem3
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    // first node of resultStartPoint is a start point(not real value)
        //    ListNode resultStartPoint = new ListNode(-1);
        //    ListNode resultPointer = resultStartPoint;
        //    ListNode firstNumPointer = l1;
        //    ListNode secondNumPointer = l2;

        //    // both input lists shouldn't be null(at least contain one node), so we use do..while
        //    do
        //    {
        //        int digitOfFirstNum = 0, digitOfSecondNum = 0;
        //        if (firstNumPointer != null)
        //        {
        //            digitOfFirstNum = firstNumPointer.val;
        //            firstNumPointer = firstNumPointer.next;
        //        }
        //        if (secondNumPointer != null)
        //        {
        //            digitOfSecondNum = secondNumPointer.val;
        //            secondNumPointer = secondNumPointer.next;
        //        }
        //        resultPointer.next = new ListNode(digitOfFirstNum + digitOfSecondNum);
        //        resultPointer = resultPointer.next;
        //    } while (firstNumPointer != null || secondNumPointer != null);

        //    return resultStartPoint.next;
        //}

        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    ListNode startPoint = new ListNode(0);
        //    ListNode resultPointer = startPoint;
        //    ListNode firstNumNowPointer = l1;
        //    ListNode secondNumNowPointer = l2;
        //    int nextDigitToAdd = 0;
        //    do
        //    {
        //        int firstListDigit = 0;
        //        int secondListDigit = 0;
        //        if (firstNumNowPointer != null)
        //            firstListDigit = firstNumNowPointer.val;
        //        if (secondNumNowPointer != null)
        //            secondListDigit = secondNumNowPointer.val;
        //        int thisDigitSum = firstListDigit + secondListDigit + nextDigitToAdd;

        //        ListNode thisNode = new ListNode(thisDigitSum % 10);
        //        if (thisDigitSum >= 10)
        //            nextDigitToAdd = 1;
        //        else
        //            nextDigitToAdd = 0;
        //        resultPointer.next = thisNode;
        //        resultPointer = resultPointer.next;
        //        if (firstNumNowPointer != null)
        //            firstNumNowPointer = firstNumNowPointer.next;
        //        if (secondNumNowPointer != null)
        //            secondNumNowPointer = secondNumNowPointer.next;

        //    } while (firstNumNowPointer != null || secondNumNowPointer != null);
        //    // end of two list but remain carry digit
        //    if(nextDigitToAdd != 0)
        //        resultPointer.next = new ListNode(1);
        //    return startPoint.next;            
        //}

        //// Implem 1
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    int result = l1.val + l2.val;
        //    return new ListNode(result);
        //}

        //// Implem2
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    int result = l1.val + l2.val;
        //    if (result >= 10)
        //    {
        //        return new ListNode(result % 10)
        //        {
        //            next = new ListNode(result / 10)
        //        };
        //    }
        //    else
        //    {
        //        return new ListNode(result);
        //    }
        //}
    }
}
