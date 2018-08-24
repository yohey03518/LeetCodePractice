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
    public class No1Test_TwoSum
    {
        private No1_TwoSum solution;

        [TestInitialize]
        public void Init()
        {
            solution = new No1_TwoSum();
        }

        [TestMethod]
        public void ArrayHas1_2_AndTargetIs3_Return0And1()
        {
            int[] array = new int[] { 1, 2 };
            int target = 3;

            int[] result = solution.GetSolution(array, target);

            Assert.IsTrue(result.Contains(0));
            Assert.IsTrue(result.Contains(1));
        }

        [TestMethod]
        public void ArrayHas1_2_3_AndTargetIs4_Return0And2()
        {
            int[] array = new int[] { 1, 2, 3 };
            int target = 4;

            int[] result = solution.GetSolution(array, target);

            Assert.IsTrue(result.Contains(0));
            Assert.IsTrue(result.Contains(2));
        }

        [TestMethod]
        public void ArrayHas2_7_11_15_AndTargetIs9_Return0And1()
        {
            int[] array = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] result = solution.GetSolution(array, target);

            Assert.IsTrue(result.Contains(0));
            Assert.IsTrue(result.Contains(1));
        }

        [TestMethod]
        public void ArrayHas3_2_4_AndTargetIs6_Return1And2()
        {
            int[] array = new int[] { 3, 2, 4 };
            int target = 6;

            int[] result = solution.GetSolution(array, target);

            Assert.IsTrue(result.Contains(2));
            Assert.IsTrue(result.Contains(1));
        }

        [TestMethod]
        public void ThereAreManySameValue()
        {
            int[] array = new int[]{230, 863, 916, 585, 981, 404, 316, 785
                , 88, 12, 70, 435, 384, 778, 887, 755
                , 740, 337, 86, 92, 325, 422, 815, 650
                , 920, 125, 277, 336, 221, 847, 168, 23
                , 677, 61, 400, 136, 874, 363, 394, 199
                , 863, 997, 794, 587, 124, 321, 212, 957
                , 764, 173, 314, 422, 927, 783, 930, 282
                , 306, 506, 44, 926, 691, 568, 68, 730, 933
                , 737, 531, 180, 414, 751, 28, 546, 60, 371
                , 493, 370, 527, 387, 43, 541, 13, 457, 328
                , 227, 652, 365, 430, 803, 59, 858, 538, 427
                , 583, 368, 375, 173, 809, 896, 370, 789};

            int target = 542;

            int[] result = solution.GetSolution(array, target);

            Assert.IsTrue(result.Contains(28));
            Assert.IsTrue(result.Contains(45));
        }
    }
}
