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

            var number = x;
            int lastDigit;
            var reversed = 0;

            while (number != 0)
            {
                lastDigit =  number % 10;
                try
                {
                    reversed = checked(reversed * 10 + lastDigit);
                }
                catch (System.OverflowException)
                {
                    return 0;
                }
                
                number = (int)(number / 10);
                Console.WriteLine(reversed);
            }

            return reversed;
        }
    }
}