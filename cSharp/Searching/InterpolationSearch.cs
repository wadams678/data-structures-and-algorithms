using System;

namespace Searching;

public class InterpolationSearch
{
    public static int DoInterpolationSearch(int[] nums, int target)
    {
        int high = nums.Length - 1;
        int low = 0;

        while (target >= nums[low] && target <= nums[high] && low <= high)
        {
            int probe = low + (high - low) *
                        (target - nums[low]) /
                        (nums[high] - nums[low]);

            if (nums[probe] == target)
            {
                return probe;
            }
            else if (nums[probe] < target)
            {
                low = probe + 1;
            }
            else
            {

                high = probe - 1;
            }
        }

        return -1;
    }
}
