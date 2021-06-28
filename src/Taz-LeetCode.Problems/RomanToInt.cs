using System.Collections.Generic;

namespace Taz_LeetCode.Problems
{
    /*
        Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        Symbol       Value
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000
        For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

        Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

        I can be placed before V (5) and X (10) to make 4 and 9. 
        X can be placed before L (50) and C (100) to make 40 and 90. 
        C can be placed before D (500) and M (1000) to make 400 and 900.
        Given a roman numeral, convert it to an integer.
    */
    public class RomanToInt
    {
        public Dictionary<char, int> _romans = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public Dictionary<char, char> _reductions = new Dictionary<char, char>()
        {
            {'V', 'I'},
            {'X', 'I'},
            {'L', 'X'},
            {'C', 'X'},
            {'D', 'C'},
            {'M', 'C'}
        };

        public int Solution(string s)
        {
            int result = 0;
            if (1 > s.Length || s.Length > 15) return result;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i < s.Length - 1 && _reductions.ContainsValue(s[i]) && _reductions.ContainsKey(s[i + 1]) && _reductions[s[i + 1]] == s[i])
                {
                    result -= _romans[s[i]];
                }
                else
                {
                    result += _romans[s[i]];
                }
                
            }
            return result;
        }
    }
}