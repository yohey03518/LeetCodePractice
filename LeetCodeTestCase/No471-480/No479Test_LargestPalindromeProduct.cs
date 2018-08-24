using System;
using System.Linq;
using LeetCodeImplement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTestCase
{
    /// <summary>
    /// Find the largest palindrome made from the product of two n-digit numbers.
    /// Since the result could be very large, you should return the largest palindrome mod 1337.
    /// Example:
    /// Input: 2
    /// Output: 987
    /// Explanation: 99 x 91 = 9009, 9009 % 1337 = 987
    /// Note:
    /// The range of n is [1,8].
    /// </summary>
    [TestClass]
    public class No479Test_LargestPalindromeProduct
    {
        private No479_LargestPalindromeProduct solution;

        [TestInitialize]
        public void Init()
        {
            solution = new No479_LargestPalindromeProduct();
        }

        [TestMethod]
        public void Nis1_Return_9()
        {
            int result = solution.LargestPalindrome(1);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Nis2_Return_987()
        {
            int result = solution.LargestPalindrome(2);
            Assert.AreEqual(987, result);
        }

        [TestMethod]
        public void Nis3_Return_123()
        {
            int result = solution.LargestPalindrome(3);
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void Nis4_Return_597()
        {
            int result = solution.LargestPalindrome(4);
            Assert.AreEqual(597, result);
        }

        [TestMethod]
        public void Nis5_Return_677()
        {
            int result = solution.LargestPalindrome(5);
            Assert.AreEqual(677, result);
        }
    }
}
