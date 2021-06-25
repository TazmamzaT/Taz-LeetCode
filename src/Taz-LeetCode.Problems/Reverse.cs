using System;

namespace Taz_LeetCode.Problems
{
    /*
        Given a signed 32-bit integer x, return x with its digits reversed.
        If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.
    */
    public class Reverse
    {
        public int Solution(int x)
        {


            // 123
            // 321
            
            // Dillon's way

            // result = 0
            // while true
            // - value = 121 % 10 -> 1
            // - shrinkingVal = Math.floor(121 / 10)
            // - if result === 0: result = value
            // - else result *= 10 + value

            // if too big, if too small return

            // else return result

            if (Math.Pow(-2, 31) >= x || x >= Math.Pow(2, 31) - 1) return 0;
            bool negative = false;
            string number;

            if (x < 0)
            {
                negative = true;
                number = (-1 * x).ToString();
            }
            else
            {
                number = x.ToString();
            }

            char[] temp = new char[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                temp[i] = number[number.Length - 1 - i];
            }

            if (negative)
            {
                return -1 * int.Parse(temp);
            }
            else
            {
                return int.Parse(temp);
            }

        }
    }
}