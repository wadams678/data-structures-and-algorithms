using System;
using sorting;

namespace TestProject;

public class SortingTest
{
    [Fact]
    public void BubbleSortTest()
    {
        // Given
        int[] unSorted = [1, 25, 16, 134, 81, 21, 54, 12];
        int[] sortedTarget = [1, 12, 16, 21, 25, 54, 81, 134];

        // When
        BubbleSort.DoBubbleSort(unSorted);

        // Then
        Assert.Equal(unSorted, sortedTarget);
    }

    [Fact]
    public void InsertionSortTest()
    {
        // Given
        int[] unSorted = [1, 25, 16, 134, 81, 21, 54, 12];
        int[] sortedTarget = [1, 12, 16, 21, 25, 54, 81, 134];

        // When
        InsertionSort.DoInsertionSort(unSorted);

        // Then
        Assert.Equal(unSorted, sortedTarget);
    }

    [Fact]
    public void MergeSortTest()
    {
        // Given
        int[] unSorted = [1, 25, 16, 134, 81, 21, 54, 12];
        int[] sortedTarget = [1, 12, 16, 21, 25, 54, 81, 134];

        // When
        MergeSort.DoMergeSort(unSorted);

        // Then
        Assert.Equal(unSorted, sortedTarget);
    }

    [Fact]
    public void QuickSortTest()
    {
        // Given
        int[] unSorted = [1, 25, 16, 134, 81, 21, 54, 12];
        int[] sortedTarget = [1, 12, 16, 21, 25, 54, 81, 134];
        int start = 0;
        int end = unSorted.Length - 1;

        // When
        QuickSort.DoQuickSort(unSorted, start, end);

        // Then
        Assert.Equal(unSorted, sortedTarget);
    }

    [Fact]
    public void SelectionSortTest()
    {
        // Given
        int[] unSorted = [1, 25, 16, 134, 81, 21, 54, 12];
        int[] sortedTarget = [1, 12, 16, 21, 25, 54, 81, 134];

        // When
        SelectionSort.DoSelectionSort(unSorted);
        
        // Then
        Assert.Equal(unSorted, sortedTarget);
    }
}
