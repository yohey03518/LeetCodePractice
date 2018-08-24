using System;
using System.Linq;
using LeetCodeImplement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTestCase
{
    /// <summary>
    /// There are two sorted arrays nums1 and nums2 of size m and n respectively.
    /// Find the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).
    /// Example 1:
    /// nums1 = [1, 3]
    /// nums2 = [2]
    ///    The median is 2.0
    /// Example 2:
    /// nums1 = [1, 2]
    ///    nums2 = [3, 4]
    ///    The median is (2 + 3)/2 = 2.5
    /// </summary>
    [TestClass]
    public class No4Test_MedianOfTwoSortedArrays
    {
        private No4_MedianOfTwoSortedArrays solution;

        [TestInitialize]
        public void Init()
        {
            solution = new No4_MedianOfTwoSortedArrays();
        }

        [TestMethod]
        public void EachArrayHasOneValue()
        {
            int[] nums1 = new int[] { 1 };
            int[] nums2 = new int[] { 4 };

            double result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2.5, result);
        }

        [TestMethod]
        public void Array1Has2Value_2Has1Value_AllSorted()
        {
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 5 };

            double result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Array1Has1Value_2Has2Value()
        {
            int[] nums1 = new int[] { 5 };
            int[] nums2 = new int[] { 1, 2 };

            double result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Example1()
        {
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };

            double result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Example2()
        {
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };

            double result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2.5, result);
        }
    }
}
