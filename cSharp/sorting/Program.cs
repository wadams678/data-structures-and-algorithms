using sorting;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nBubble Sort");
        int[] nums = [54, 12, 36, 14, 52, 45, 88, 66, 11, 45];
        BubbleSort.DoBubbleSort(nums);

        Console.WriteLine("\nInsertion Sort");
        nums = [54, 12, 36, 14, 52, 45, 88, 66, 11, 45];
        InsertionSort.DoInsertionSort(nums);

        Console.WriteLine("\nMerge Sort");
        nums = [54, 12, 36, 14, 52, 45, 88, 66, 11, 45];
        MergeSort.DoMergeSort(nums);

        Console.WriteLine("\nQuick Sort");
        nums = [54, 12, 36, 14, 52, 45, 88, 66, 11, 45];
        QuickSort.DoQuickSort(nums, 0, nums.Length - 1);

        Console.WriteLine("\nSelection Sort");
        nums = [54, 12, 36, 14, 52, 45, 88, 66, 11, 45];
        SelectionSort.DoSelectionSort(nums);
    }
}