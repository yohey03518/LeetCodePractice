using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeImplement
{
    /// <summary>
    /// Given an array of integers, find if the array contains any duplicates.
    /// Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
    /// </summary>
    public class No217_ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            int distinctNums = nums.Distinct().Count();
            int originalNums = nums.Count();
            return distinctNums != originalNums;
        }

        // Accepted
        //public bool ContainsDuplicate(int[] nums)
        //{
        //    nums = nums.OrderBy(m => m).ToArray();
        //    for(int i = 1; i < nums.Count(); i++)
        //    {
        //        if (nums[i] == nums[i - 1]) return true;
        //    }
        //    return false;
        //}


        // 數量多 時間會超過
        //public bool ContainsDuplicate(int[] nums)
        //{
        //    int count = nums.Count();
        //    if (count == 0) return false;

        //    Node root = null;
        //    for (int i = 0; i < count; i++)
        //    {
        //        int value = nums[i];
        //        Node pointer = root;
        //        Node prePtr = null;
        //        do
        //        {
        //            if (root == null)
        //            {
        //                root = new Node(value);
        //                pointer = root;
        //            }
        //            else if (pointer != null && value > pointer.Value)
        //            {
        //                if (pointer.Right == null)
        //                {
        //                    pointer.Right = new Node(value);
        //                    break;
        //                }
        //                else
        //                {
        //                    prePtr = pointer;
        //                    pointer = pointer.Right;
        //                    if (pointer == null)
        //                    {
        //                        prePtr.Right = new Node(value);
        //                    }
        //                }
        //            }
        //            else if (pointer != null && value < pointer.Value)
        //            {
        //                if (pointer.Left == null)
        //                {
        //                    pointer.Left = new Node(value);
        //                    break;
        //                }
        //                else
        //                {
        //                    prePtr = pointer;
        //                    pointer = pointer.Left;
        //                    if (pointer == null)
        //                    {
        //                        prePtr.Left = new Node(value);
        //                    }
        //                }
        //            }
        //            else if (pointer != null && value == pointer.Value)
        //            {
        //                return true;
        //            }
        //        } while (prePtr != null || pointer.Left != null || pointer.Right != null);
        //    }
        //    return false;
        //}

        public class Node
        {
            public Node Left;
            public Node Right;
            public int Value;
            public Node(int v) { Value = v; }
        }

        // 沒考慮數字超大記憶體炸掉
        //public bool ContainsDuplicate(int[] nums)
        //{
        //    int count = nums.Count();
        //    if (count == 0) return false;
        //    int max = nums.Max();
        //    int min = nums.Min();
        //    int[] positiveRecord = new int[max + 1];
        //    int[] negativeRecord = new int[(min < 0) ? Math.Abs(min) + 1 : 0];
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (nums[i] >= 0)
        //        {
        //            if (positiveRecord[nums[i]] == 1)
        //                return true;
        //            else
        //                positiveRecord[nums[i]] = 1;
        //        }
        //        else
        //        {
        //            if (negativeRecord[nums[i] * -1] == 1)
        //                return true;
        //            else
        //                negativeRecord[nums[i] * -1] = 1;
        //        }
        //    }
        //    return false;
        //}

        //沒考慮負數
        //public bool ContainsDuplicate(int[] nums)
        //{
        //    int count = nums.Count();
        //    if (count == 0) return false;
        //    int max = nums.Max();

        //    int[] record = new int[max + 1];
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (record[nums[i]] == 1)
        //            return true;
        //        else
        //            record[nums[i]] = 1;
        //    }
        //    return false;
        //}
    }

}
