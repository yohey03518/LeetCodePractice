using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeImplement
{
    /// <summary>
    /// Given a string, find the length of the longest substring without repeating characters.
    /// Examples:
    /// Given "abcabcbb", the answer is "abc", which the length is 3.
    /// Given "bbbbb", the answer is "b", with the length of 1.
    /// Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
    /// </summary>
    public class No3_LongestSubstringWithoutRepeatingCharacters
    {
        public int GetLengthOfLongestSubstring(string s)
        {
            int nowMaxLength = 0;
            Dictionary<char, int> charIndex = new Dictionary<char, int>();
            for (int index = 0; index < s.Length; )
            {
                // bump into same char, restart from the first duplicated char's next char
                if(charIndex.ContainsKey(s[index]))
                {
                    index = charIndex[s[index]] + 1;                    
                    if (charIndex.Count > nowMaxLength)
                        nowMaxLength = charIndex.Count;
                    charIndex = new Dictionary<char, int>();
                }
                else
                {
                    charIndex.Add(s[index], index);
                    // end of the string, check length
                    if(index == s.Length - 1 && charIndex.Count > nowMaxLength)
                        nowMaxLength = charIndex.Count;
                    index++;
                }
            }
            return nowMaxLength;
        }

        //public int GetLengthOfLongestSubstring(string s)
        //{
        //    int nowMaxLength = 0;
        //    List<char> nowString = new List<char>();
        //    for (int k = 0; k < s.Length; k++)
        //    {
        //        for (int i = k; i < s.Length; i++)
        //        {
        //            // bump into the same char
        //            if (nowString.Contains(s[i]))
        //            {
        //                if (nowString.Count > nowMaxLength)
        //                    nowMaxLength = nowString.Count;
        //                nowString = new List<char>();
        //            }
        //            nowString.Add(s[i]);

        //            // last char
        //            if (i == s.Length - 1 && nowString.Count > nowMaxLength)
        //            {
        //                nowMaxLength = nowString.Count;
        //            }
        //        }
        //        nowString = new List<char>();
        //    }
        //    return nowMaxLength;
        //}

        //imple2
        //public int GetLengthOfLongestSubstring(string s)
        //{
        //    int nowMaxLength = 0;
        //    List<char> nowString = new List<char>();
        //    for(int i = 0; i < s.Length; i++)
        //    {
        //        // bump into the same char
        //        if(nowString.Contains(s[i]))
        //        {
        //            if (nowString.Count > nowMaxLength)
        //                nowMaxLength = nowString.Count;
        //            nowString = new List<char>();
        //        }
        //        nowString.Add(s[i]);
        //        // last char
        //        if(i == s.Length - 1)
        //        {
        //            if (nowString.Count > nowMaxLength)
        //                nowMaxLength = nowString.Count;
        //        }
        //    }
        //    return nowMaxLength;
        //}

        // Imple1 2
        //public int GetLengthOfLongestSubstring(string s)
        //{
        //    if (s.Distinct().Count() == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return s.Length;
        //    }
        //}
    }
}
