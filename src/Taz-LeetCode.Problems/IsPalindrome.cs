namespace Taz_LeetCode.Problems
{
    /*
        Given an integer x, return true if x is palindrome integer.
        An integer is a palindrome when it reads the same backward as forward. For example, 121 is palindrome while 123 is not.
    */
    public class IsPalindrome
    {
        public bool Solution(int x)
        {
            if (x < 0) return false;

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
                    return false;
                }
                
                number = (int)(number / 10);
            }

            if (reversed == x) return true; else return false;
        }
    }
}