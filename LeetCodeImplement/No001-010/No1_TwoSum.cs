using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeImplement
{
    /// <summary>
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// Example: 
    /// Given nums = [2, 7, 11, 15], target = 9,
    /// Because nums[0] + nums[1] = 2 + 7 = 9,
    /// return [0, 1].
    /// </summary>
    public class No1_TwoSum
    {
        //public int[] GetSolution(int[] nums, int target)
        //{
        //    for (int index1 = 0; index1 < nums.Count(); index1++)
        //    {
        //        for (int index2 = (index1 + 1); index2 < nums.Count(); index2++)
        //        {
        //            if (nums[index1] + nums[index2] == target)
        //                return new int[] { index1, index2 };
        //        }
        //    }
        //    throw new Exception("No match result!");
        //}

        public int[] GetSolution(int[] nums, int target)
        {
            // First int means the excepted second value, the second int means the index of first value
            Dictionary<int, int> exceptValueMap = new Dictionary<int, int>();
            for (int index1 = 0; index1 < nums.Count(); index1++)
            {
                // the value in array matches the excepted value
                if (exceptValueMap.ContainsKey(nums[index1]))
                {
                    return new int[] { exceptValueMap[nums[index1]], index1 };
                }
                // check whether the value has already exist in the dictionary
                else if (!exceptValueMap.ContainsKey(target - nums[index1]))
                {
                    exceptValueMap.Add(target - nums[index1], index1);
                }
            }
            throw new Exception("No match result!");
        }
    }

}
