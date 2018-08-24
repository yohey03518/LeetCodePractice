using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeImplement
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
    public class No4_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int nums1Count = nums1.Count();
            int nums2Count = nums2.Count();
            int[] all = new int[nums1Count + nums2Count];
            int allNextAddIndex = 0;
            int i1 = 0, i2 = 0;
            while (i1 < nums1Count || i2 < nums2Count)
            {
                if (i1 < nums1Count && i2 < nums2Count)
                    all[allNextAddIndex++] = (nums1[i1] < nums2[i2]) ? nums1[i1++] : nums2[i2++];
                else if (i1 < nums1Count)
                    all[allNextAddIndex++] = nums1[i1++];
                else if (i2 < nums2Count)
                    all[allNextAddIndex++] = nums2[i2++];
            }

            int count = allNextAddIndex;
            if (count % 2 == 0)
                // minus 1 : because of the index start with 0
                return (double)(all[count / 2 - 1] + all[count / 2]) / 2;
            else
                return all[count / 2];
        }


        //Impl3
        //public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        //{
        //    int nums1Count = nums1.Count();
        //    int nums2Count = nums2.Count();
        //    int[] all = new int[nums1Count + nums2Count];
        //    int allNextAddIndex = 0;
        //    int i1 = 0, i2 = 0;
        //    while(i1 < nums1Count || i2 < nums2Count)
        //    {
        //        if (i1 < nums1Count && i2 < nums2Count)
        //            all[allNextAddIndex++] = (nums1[i1] < nums2[i2]) ? nums1[i1++] : nums2[i2++];
        //        else if (i1 < nums1Count)
        //            all[allNextAddIndex++] = nums1[i1++];
        //        else if (i2 < nums2Count)
        //            all[allNextAddIndex++] = nums2[i2++];
        //    }

        //    int count = allNextAddIndex;
        //    if (count % 2 == 0)
        //        // minus 1 : because of the index start with 0
        //        return (double)(all[count / 2 - 1] + all[count / 2]) / 2;
        //    else
        //        return all[count / 2];
        //}

        //Impl2
        //public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        //{
        //    List<int> all = nums1.ToList();
        //    all.AddRange(nums2);
        //    int count = all.Count;
        //    if (count % 2 == 0)
        //        // minus 1 : because of the index start with 0
        //        return (double)(all[count / 2 - 1] + all[count / 2]) / 2;
        //    else
        //        return all[count / 2];
        //}

        //Impl1
        //public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        //{
        //    return (double)(nums1[0] + nums2[0]) / 2;
        //}
    }

}
