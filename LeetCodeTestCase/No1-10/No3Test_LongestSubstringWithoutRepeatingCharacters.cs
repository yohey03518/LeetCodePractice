using System;
using System.Linq;
using LeetCodeImplement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTestCase
{
    /// <summary>
    /// Given a string, find the length of the longest substring without repeating characters.
    /// Examples:
    /// Given "abcabcbb", the answer is "abc", which the length is 3.
    /// Given "bbbbb", the answer is "b", with the length of 1.
    /// Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
    /// </summary>
    [TestClass]
    public class No3Test_LongestSubstringWithoutRepeatingCharacters
    {
        private No3_LongestSubstringWithoutRepeatingCharacters solution;

        [TestInitialize]
        public void Init()
        {
            solution = new No3_LongestSubstringWithoutRepeatingCharacters();
        }

        [TestMethod]
        public void OneCharacter_Return1()
        {
            string input = "a";
            int resultLength = solution.GetLengthOfLongestSubstring(input);
            Assert.AreEqual(1, resultLength);        
        }

        [TestMethod]
        public void TwoSameCharacters_Return1()
        {
            string input = "aa";
            int resultLength = solution.GetLengthOfLongestSubstring(input);
            Assert.AreEqual(1, resultLength);
        }

        [TestMethod]
        public void TwoRepeatCharAndAnotherChar_aab_Return2()
        {
            string input = "aab";
            int resultLength = solution.GetLengthOfLongestSubstring(input);
            Assert.AreEqual(2, resultLength);
        }

        [TestMethod]
        public void OfficialCase1_abcabcbb_Return3()
        {
            string input = "abcabcbb";
            int resultLength = solution.GetLengthOfLongestSubstring(input);
            Assert.AreEqual(3, resultLength);
        }

        [TestMethod]
        public void OfficialCase1_bbbbb_Return1()
        {
            string input = "bbbbb";
            int resultLength = solution.GetLengthOfLongestSubstring(input);
            Assert.AreEqual(1, resultLength);
        }

        [TestMethod]
        public void OfficialCase1_pwwkew_Return3()
        {
            string input = "pwwkew";
            int resultLength = solution.GetLengthOfLongestSubstring(input);
            Assert.AreEqual(3, resultLength);
        }

        [TestMethod]
        public void SubmitCase1_dvdf_Return3()
        {
            string input = "dvdf";
            int resultLength = solution.GetLengthOfLongestSubstring(input);
            Assert.AreEqual(3, resultLength);
        }

        [TestMethod]
        public void SubmitCase1_asjrgapa_Return6()
        {
            string input = "asjrgapa";
            int resultLength = solution.GetLengthOfLongestSubstring(input);
            Assert.AreEqual(6, resultLength);
        }
    }
}
