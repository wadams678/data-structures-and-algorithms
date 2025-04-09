using System;

namespace sorting;

public class BubbleSort
{
    public static void DoBubbleSort(int[] nums)
    {

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    (nums[j + 1], nums[j]) = (nums[j], nums[j + 1]);
                }
            }
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");
        }

        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
    }
}
