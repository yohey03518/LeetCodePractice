using System;
using System.Linq;
using LeetCodeImplement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTestCase
{
    /// <summary>
    /// Given an array of integers, find if the array contains any duplicates.
    /// Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
    /// </summary>
    [TestClass]
    public class No217Test_ContainsDuplicate
    {
        private No217_ContainsDuplicate solution;

        [TestInitialize]
        public void Init()
        {
            solution = new No217_ContainsDuplicate();
        }

        [TestMethod]
        public void Array1231_ReturnTrue()
        {
            int[] array = new int[4] { 1, 2, 3, 1 };
            bool isDuplicate = solution.ContainsDuplicate(array);
            Assert.IsTrue(isDuplicate);
        }

        [TestMethod]
        public void Array1234_ReturnFalse()
        {
            int[] array = new int[4] { 1, 2, 3, 4 };
            bool isDuplicate = solution.ContainsDuplicate(array);
            Assert.IsFalse(isDuplicate);
        }

        [TestMethod]
        public void Array1113343242_ReturnTrue()
        {
            int[] array = new int[10] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool isDuplicate = solution.ContainsDuplicate(array);
            Assert.IsTrue(isDuplicate);
        }

        [TestMethod]
        public void ArrayContain0andNagativeNoDuplicate_ReturnFalse()
        {
            int[] array = new int[5] { 1, 5, -2, -4, 0 };
            bool isDuplicate = solution.ContainsDuplicate(array);
            Assert.IsFalse(isDuplicate);
        }

        [TestMethod]
        public void ArrayContain2SameHugeNumber_ReturnTrue()
        {
            int[] array = new int[2] { -1200000005, -1200000005 };
            bool isDuplicate = solution.ContainsDuplicate(array);
            Assert.IsTrue(isDuplicate);
        }

        [TestMethod]
        public void Array2_14_18_22_22_ReturnTrue()
        {
            int[] array = new int[5] { 2, 14, 18, 22, 22 };
            bool isDuplicate = solution.ContainsDuplicate(array);
            Assert.IsTrue(isDuplicate);
        }
    }
}
;