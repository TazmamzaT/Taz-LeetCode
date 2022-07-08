using System.Collections.Generic;

namespace Taz_LeetCode.Problems;

/**
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
*/
public class TwoSum {

    public int[] Solution(int[] nums, int target) {
        //Current value, Target - Current value
        Dictionary<int, int> yeet = new Dictionary<int, int>();
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {

            if (yeet.ContainsKey(target-nums[i]))
            {
                result[0] = yeet[target-nums[i]];
                result[1] = i;
                return result;
            }

            yeet.Add(nums[i], i);
        }
        return result;
    }
}

