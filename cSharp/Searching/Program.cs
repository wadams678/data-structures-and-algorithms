


using Searching;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] sortedNums = [1, 5, 9, 14, 20, 35, 39, 45, 62, 68, 77, 88, 90, 105, 115];
        int[] unSortedNums = [54, 12, 36, 14, 52, 45, 88, 66, 11, 452, 1];
        int target = 45;

        int index = LinearSearch.DoLinearSearch(unSortedNums, target);
        Console.WriteLine("Linear Search value " + index);

        int binarySearchIndex = BinarySearch.DoBinarySearch(sortedNums, target);
        Console.WriteLine("Binary search index value " + binarySearchIndex);

        int interpolationSearch = InterpolationSearch.DoInterpolationSearch(sortedNums, target);
        Console.WriteLine("Interpolation search index value " + interpolationSearch);
    }
}