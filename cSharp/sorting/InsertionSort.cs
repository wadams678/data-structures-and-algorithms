using System;

namespace sorting;

public class InsertionSort
{

    public static void DoInsertionSort(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            int temp = nums[i];
            int j = i - 1;

            while (j >= 0 && nums[j] > temp)
            {
                nums[j + 1] = nums[j];
                j--;
            }
            nums[j + 1] = temp;

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");
        }
    }
}
