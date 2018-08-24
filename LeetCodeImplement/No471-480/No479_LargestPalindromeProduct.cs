using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeImplement
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
    public class No479_LargestPalindromeProduct
    {
        public int LargestPalindrome(int n)
        {
            // 相乘的最大位數(最小位數就再減一即可)
            int maxDigits = n + n;

            // 單一數字最大及最小值
            long maxValueOneNumber = (long)Math.Pow(10, n);
            long minValueOneNumber = maxValueOneNumber / 10;
            maxValueOneNumber -= 1;

            // 單邊數字的最大值
            long maxHalf = (maxValueOneNumber * maxValueOneNumber) / (long)Math.Pow(10, n);

            // 由大到小產生回文的值並判斷能否整除 (偶數位數的情況)
            for (long halfValue = maxHalf; halfValue >= minValueOneNumber; halfValue--)
            {
                // 透過半邊的數字產出回文值 如987產生987789
                long value = long.Parse(halfValue.ToString() + new string(halfValue.ToString().Reverse().ToArray()));
                for (long nDigitValue = maxValueOneNumber; nDigitValue >= minValueOneNumber; nDigitValue--)
                {
                    if(value % nDigitValue == 0)
                    {
                        long r = value / nDigitValue;
                        if (r >= minValueOneNumber && r <= maxValueOneNumber)
                            return (int)(value % 1337);
                    }
                }
            }

            // 由大到小產生回文的值並判斷能否整除 (奇數位數的情況)
            for (long halfValue = maxValueOneNumber; halfValue >= minValueOneNumber; halfValue--)
            {
                // 透過半邊的數字產出回文值放在陣列中 如987產生98789
                long value = long.Parse(halfValue.ToString() + new string(halfValue.ToString().Substring(0, n-1).Reverse().ToArray()));
                for (long nDigitValue = maxValueOneNumber; nDigitValue >= minValueOneNumber; nDigitValue--)
                {
                    if (value % nDigitValue == 0)
                    {
                        long r = value / nDigitValue;
                        if (r >= minValueOneNumber && r <= maxValueOneNumber)
                            return (int)(value % 1337);
                    }
                }
            }
            return -1;
        }

        //public int LargestPalindrome(int n)
        //{
        //    // 計算出兩個n位數相乘時每個數的最大及最小值
        //    long maxValueOneNumber = 1, minValueOneNumber;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        maxValueOneNumber *= 10;
        //    }
        //    minValueOneNumber = maxValueOneNumber / 10;
        //    maxValueOneNumber -= 1;

        //    // 開始進行n位數的兩兩相乘列舉並留下最大的回文值
        //    long maxPalindromeValue = 0;
        //    for (long n1 = maxValueOneNumber; n1 >= minValueOneNumber; n1--)
        //    {
        //        for (long n2 = maxValueOneNumber; n2 >= minValueOneNumber; n2--)
        //        {
        //            long value = n1 * n2;
        //            if (value > maxPalindromeValue)
        //            {
        //                // -------判斷是否是回文------
        //                // 取得此乘積的位數並依序紀錄每個位數的資料
        //                int digitsCount = 0;
        //                int[] digits = new int[n + n];
        //                for (long modValue = value; modValue > 0; modValue /= 10)
        //                {
        //                    digits[digitsCount] = int.Parse((modValue % 10).ToString());
        //                    digitsCount++;
        //                }
        //                // 取得中間那個位數在陣列中的位址 如值1234會取得2的位址(1)，12345會取得3的位址(2)
        //                int centerDigitIndex = ((digitsCount + 1) / 2) - 1;
        //                bool isOdd = digitsCount % 2 == 1;
        //                int forwardCompareIndex = isOdd ? (centerDigitIndex - 1) : centerDigitIndex;
        //                bool isPalindrome = true;
        //                for (int compareIndex = centerDigitIndex + 1; compareIndex <= digitsCount - 1 && forwardCompareIndex >= 0; compareIndex++, forwardCompareIndex--)
        //                {
        //                    if(digits[compareIndex] != digits[forwardCompareIndex])
        //                    {
        //                        isPalindrome = false;
        //                        break;
        //                    }
        //                }
        //                if (isPalindrome)
        //                    maxPalindromeValue = value;
        //            }
        //        }
        //    }
        //    return int.Parse((maxPalindromeValue % 1337).ToString());
        //}
    }

}
