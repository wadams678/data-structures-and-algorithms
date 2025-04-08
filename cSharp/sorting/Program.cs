



internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = [54, 12, 36, 14, 52, 45, 88, 66, 11, 45];
        BubbleSort(nums);
        InsertionSort(nums);
        MergeSort(nums);
    }



    private static void MergeSort(int[] nums)
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

        MergeSort(leftArray);
        MergeSort(rightArray);

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

    private static void InsertionSort(int[] nums)
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

    private static void BubbleSort(int[] nums)
    {

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
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