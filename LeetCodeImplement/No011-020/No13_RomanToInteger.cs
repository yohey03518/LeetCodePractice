using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeImplement
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
    public class No13_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            int count = s.Count();
            char setChar = '\b';
            for (int i = count - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case 'I':
                        if (setChar == 'V' || setChar == 'X')
                            result -= 1;
                        else
                            result += 1;
                        break;
                    case 'V':
                        setChar = 'V';
                        result += 5;
                        break;
                    case 'X':
                        if (setChar == 'L' || setChar == 'C')
                            result -= 10;
                        else
                        {
                            setChar = 'X';
                            result += 10;
                        }                            
                        break;
                    case 'L':
                        setChar = 'L';
                        result += 50;
                        break;
                    case 'C':
                        if (setChar == 'D' || setChar == 'M')
                            result -= 100;
                        else
                        {
                            setChar = 'C';
                            result += 100;
                        }                        
                        break;
                    case 'D':
                        setChar = 'D';
                        result += 500;
                        break;
                    case 'M':
                        setChar = 'M';
                        result += 1000;
                        break;
                }
            }
            return result;
        }
    }
}
