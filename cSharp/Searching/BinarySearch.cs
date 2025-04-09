using System;

namespace Searching;

public class BinarySearch
{
    public static int DoBinarySearch(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int middle = low + (high - low) / 2;
            int value = nums[middle];

            if (value < target) low = middle + 1;
            else if (value > target) high = middle - 1;
            else return middle; //target found
        }

        return -1; // target not found
    }
}
