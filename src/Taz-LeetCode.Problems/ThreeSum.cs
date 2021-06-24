using System.Collections.Generic;
using System;

namespace Taz_LeetCode.Problems
{
    /**
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
        Notice that the solution set must not contain duplicate triplets.
    */
    public class ThreeSum {

        public IList<IList<int>> Solution(int[] nums) {
            var yeet = new Dictionary<int, IList<int>>();
            
            var result = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!yeet.ContainsKey(nums[i]))
                {
                    var current = new List<int>();
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] != nums[i] && j != i)
                        {
                            current.Add(nums[i] + nums[j]);
                        }
                    }
                    yeet.Add(nums[i], current);
                }
            }

            foreach(KeyValuePair<int, IList<int>> yote in yeet)
            {
                foreach(int lonk in yote.Value)
                {
                    if (yeet.ContainsKey(-1 * (yote.Key + lonk)) && lonk != yote.Key && -1 * (yote.Key + lonk) != yote.Key)
                    {
                        result.Add(new List<int>(){yote.Key, lonk - yote.Key, -1 * (yote.Key + lonk)});
                    }
                }
            }

            return result;
        }
    }
}

