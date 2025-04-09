using System;

namespace Searching;

public class LinearSearch
{
    public static int DoLinearSearch(int[] nums, int value)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == value)
            {
                return i;
            }
        }

        return -1;
    }
}
