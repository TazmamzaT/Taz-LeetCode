using System;
namespace Taz_LeetCode.Problems
{
    public class LongestCommonPrefix
    {
        public string Solution(string[] strs) {
            if (strs.Length > 200 || strs.Length == 0) return string.Empty;
            if (strs.Length == 1) return strs[0];

            int shortest = int.MaxValue;
            int j = 0;

            for (int i = 0; i < strs.Length - 1; i++)
            {
                if (strs[i].Length > 200 || strs[i].Length == 0) return string.Empty;

                while(j < strs[i].Length && j < strs[i + 1].Length && strs[i][j] == strs[i + 1][j])
                {
                    j++;
                }

                if (j == 0) return string.Empty;
                if (j < shortest) shortest = j;
                j = 0;
            }

            return strs[1].Substring(0, shortest);
        }
    }
}