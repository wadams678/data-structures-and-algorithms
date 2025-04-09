using System;

namespace sorting;

public class MergeSort
{

    public static void DoMergeSort(int[] nums)
    {
        int length = nums.Length;
        if (length <= 1) return;

        int middle = length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[length - middle];

        int i = 0; //left
        int j = 0; //right

        for (; i < length; i++)
        {
            if (i < middle)
            {
                leftArray[i] = nums[i];
            }
            else
            {
                rightArray[j] = nums[i];
                j++;
            }
        }

        DoMergeSort(leftArray);
        DoMergeSort(rightArray);

        Merge(leftArray, rightArray, nums);

        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("");
    }

    private static void Merge(int[] leftArry, int[] rightArray, int[] array)
    {
        int leftSize = array.Length / 2;
        int rightSize = array.Length - leftSize;

        int i = 0, l = 0, r = 0;

        while (l < leftSize && r < rightSize)
        {
            if (leftArry[l] < rightArray[r])
            {
                array[i] = leftArry[l];
                i++;
                l++;
            }
            else
            {
                array[i] = rightArray[r];
                i++;
                r++;
            }
        }

        while (l < leftSize)
        {
            array[i] = leftArry[l];
            i++;
            l++;
        }

        while (r < rightSize)
        {
            array[i] = rightArray[r];
            i++;
            r++;
        }

    }
}
