using System;

namespace sorting;

public class QuickSort
{
    public static void DoQuickSort(int[] nums, int start, int end)
    {
        if (end <= start) return; //base case
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("");
        int pivot = Partition(nums, start, end);
        DoQuickSort(nums, start, pivot - 1);
        DoQuickSort(nums, pivot + 1, end);

    }


    private static int Partition(int[] nums, int start, int end)
    {
        int pivot = nums[end];
        int i = start - 1;

        for (int j = start; j <= end - 1; j++)
        {
            if (nums[j] < pivot)
            {
                i++;
                (nums[j], nums[i]) = (nums[i], nums[j]); //int temp = nums[i]; nums[i] = nums[j];  nums[j] = temp;
            }
        }
        i++;
        (nums[end], nums[i]) = (nums[i], nums[end]);

        return i;
    }
}
