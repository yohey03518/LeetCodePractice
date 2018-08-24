using System;
using System.Linq;
using LeetCodeImplement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTestCase
{
    /// <summary>
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// Example: 
    /// Given nums = [2, 7, 11, 15], target = 9,
    /// Because nums[0] + nums[1] = 2 + 7 = 9,
    /// return [0, 1].
    /// </summary>
    [TestClass]
    public class No2Test_AddTwoNumbers
    {
        private No2_AddTwoNumbers solution;

        [TestInitialize]
        public void Init()
        {
            solution = new No2_AddTwoNumbers();
        }

        [TestMethod]
        public void OneDigit_AddOneDigit_ReturnValueLessThan10_1_Plus_1_Equal2()
        {
            No2_AddTwoNumbers.ListNode firstNumber = new No2_AddTwoNumbers.ListNode(1);
            No2_AddTwoNumbers.ListNode secondNumber = new No2_AddTwoNumbers.ListNode(1);

            No2_AddTwoNumbers.ListNode result = solution.AddTwoNumbers(firstNumber, secondNumber);

            Assert.AreEqual(2, result.val);
            Assert.IsTrue(result.next == null);
        }

        [TestMethod]
        public void OneDigit_AddOneDigit_ReturnValueGreaterThan10_3_Plus_9_Equal12()
        {
            No2_AddTwoNumbers.ListNode firstNumber = new No2_AddTwoNumbers.ListNode(3);
            No2_AddTwoNumbers.ListNode secondNumber = new No2_AddTwoNumbers.ListNode(9);

            No2_AddTwoNumbers.ListNode result = solution.AddTwoNumbers(firstNumber, secondNumber);

            // result should be 12, first digit in linked list is 2, the second digit is 1
            Assert.AreEqual(2, result.val);
            Assert.AreEqual(1, result.next.val);
        }

        [TestMethod]
        public void OneDigit_AddThreeDigit_3_Plus_325_Equa328()
        {
            No2_AddTwoNumbers.ListNode firstNumber = new No2_AddTwoNumbers.ListNode(3);
            No2_AddTwoNumbers.ListNode secondNumber = 
                new No2_AddTwoNumbers.ListNode(5)
                {
                    next = new No2_AddTwoNumbers.ListNode(2)
                    {
                        next = new No2_AddTwoNumbers.ListNode(3)
                    }
                };
            No2_AddTwoNumbers.ListNode result1 = solution.AddTwoNumbers(firstNumber, secondNumber);
            No2_AddTwoNumbers.ListNode result2 = solution.AddTwoNumbers(secondNumber, firstNumber);

            Assert.AreEqual(8, result1.val);
            Assert.AreEqual(2, result1.next.val);
            Assert.AreEqual(3, result1.next.next.val);
            Assert.AreEqual(8, result2.val);
            Assert.AreEqual(2, result2.next.val);
            Assert.AreEqual(3, result2.next.next.val);
        }
        
        [TestMethod]
        public void MultiCarry_3_Plus_99_Equa102()
        {
            No2_AddTwoNumbers.ListNode firstNumber = new No2_AddTwoNumbers.ListNode(3);
            No2_AddTwoNumbers.ListNode secondNumber =
                new No2_AddTwoNumbers.ListNode(9)
                {
                    next = new No2_AddTwoNumbers.ListNode(9)
                };
            No2_AddTwoNumbers.ListNode result1 = solution.AddTwoNumbers(firstNumber, secondNumber);
            
            Assert.AreEqual(2, result1.val);
            Assert.AreEqual(0, result1.next.val);
            Assert.AreEqual(1, result1.next.next.val);
        }
    }
}
