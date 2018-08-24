using System;
using System.Linq;
using LeetCodeImplement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTestCase
{
    /// <summary>
    /// Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.
    /// Symbol       Value
    /// I             1
    /// V             5
    /// X             10
    /// L             50
    /// C             100
    /// D             500
    /// M             1000
    /// </summary>
    [TestClass]
    public class No13Test_RomanToInteger
    {
        private No13_RomanToInteger solution;

        [TestInitialize]
        public void Init()
        {
            solution = new No13_RomanToInteger();
        }

        #region One Char

        [TestMethod]
        public void I_Return_1()
        {
            Assert.AreEqual(1, solution.RomanToInt("I"));
        }

        [TestMethod]
        public void V_Return_5()
        {
            Assert.AreEqual(5, solution.RomanToInt("V"));
        }

        [TestMethod]
        public void X_Return_10()
        {
            Assert.AreEqual(10, solution.RomanToInt("X"));
        }

        [TestMethod]
        public void L_Return_50()
        {
            Assert.AreEqual(50, solution.RomanToInt("L"));
        }

        [TestMethod]
        public void C_Return_100()
        {
            Assert.AreEqual(100, solution.RomanToInt("C"));
        }

        [TestMethod]
        public void D_Return_500()
        {
            Assert.AreEqual(500, solution.RomanToInt("D"));
        }

        [TestMethod]
        public void M_Return_1000()
        {
            Assert.AreEqual(1000, solution.RomanToInt("M"));
        }

        #endregion

        #region One Char With Left Or Right Chars

        [TestMethod]
        public void VI_Return_6()
        {
            Assert.AreEqual(6, solution.RomanToInt("VI"));
        }

        [TestMethod]
        public void VII_Return_7()
        {
            Assert.AreEqual(7, solution.RomanToInt("VII"));
        }

        [TestMethod]
        public void IV_Return_4()
        {
            Assert.AreEqual(4, solution.RomanToInt("IV"));
        }

        [TestMethod]
        public void XI_Return_11()
        {
            Assert.AreEqual(11, solution.RomanToInt("XI"));
        }

        [TestMethod]
        public void XII_Return_12()
        {
            Assert.AreEqual(12, solution.RomanToInt("XII"));
        }

        [TestMethod]
        public void IX_Return_9()
        {
            Assert.AreEqual(9, solution.RomanToInt("IX"));
        }

        [TestMethod]
        public void LX_Return_60()
        {
            Assert.AreEqual(60, solution.RomanToInt("LX"));
        }

        [TestMethod]
        public void XL_Return_40()
        {
            Assert.AreEqual(40, solution.RomanToInt("XL"));
        }

        [TestMethod]
        public void CX_Return_110()
        {
            Assert.AreEqual(110, solution.RomanToInt("CX"));
        }

        [TestMethod]
        public void XC_Return_90()
        {
            Assert.AreEqual(90, solution.RomanToInt("XC"));
        }

        [TestMethod]
        public void DC_Return_600()
        {
            Assert.AreEqual(600, solution.RomanToInt("DC"));
        }

        [TestMethod]
        public void CD_Return_400()
        {
            Assert.AreEqual(400, solution.RomanToInt("CD"));
        }

        [TestMethod]
        public void CM_Return_900()
        {
            Assert.AreEqual(900, solution.RomanToInt("CM"));
        }

        [TestMethod]
        public void MC_Return_1100()
        {
            Assert.AreEqual(1100, solution.RomanToInt("MC"));
        }

        #endregion

        [TestMethod]
        public void III_Return_3()
        {
            Assert.AreEqual(3, solution.RomanToInt("III"));
        }

        [TestMethod]
        public void LVIII_Return_58()
        {
            Assert.AreEqual(58, solution.RomanToInt("LVIII"));
        }

        [TestMethod]
        public void MCMXCIV_Return_1994()
        {
            Assert.AreEqual(1994, solution.RomanToInt("MCMXCIV"));
        }
    }
}
