


using Searching;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = [54, 12, 36, 14, 52, 45, 88, 66, 11, 452, 1];
        int index = LinearSearch.DoLinearSearch(nums, 15);
        Console.WriteLine(index);

        int target = 45;
        int binarySearchIndex = BinarySearch.DoBinarySearch(nums, target);
        Console.WriteLine(binarySearchIndex);
    }




}