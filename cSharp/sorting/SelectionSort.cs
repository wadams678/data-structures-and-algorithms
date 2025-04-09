using System;

namespace sorting;

public class SelectionSort
{

    public static void DoSelectionSort(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[min] > nums[j])
                {
                    min = j;
                }
            }

            (nums[min], nums[i]) = (nums[i], nums[min]);

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("");
        }
    }

}
