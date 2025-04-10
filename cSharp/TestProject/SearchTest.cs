using System;
using Searching;

namespace TestProject;

public class SearchTest
{

    [Fact]
    public void LinearSearchTargetFoundReturnIndex()
    {
        // Given
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
        int target = 9;
        // When
        int result = BinarySearch.DoBinarySearch(nums, target);
        // Then
        Assert.Equal(8, result);
    }

    [Fact]
    public void LinearSearchTargetFoundReturnMinusOne()
    {
        // Given
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
        int target = 25;
        // When
        int result = LinearSearch.DoLinearSearch(nums, target);
        // Then
        Assert.Equal(-1, result);
    }
    [Fact]
    public void BinarySearchTargetFoundReturnIndex()
    {
        // Given
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
        int target = 9;
        // When
        int result = BinarySearch.DoBinarySearch(nums, target);
        // Then
        Assert.Equal(8, result);
    }

    [Fact]
    public void BinarySearchTargetFoundReturnMinusOne()
    {
        // Given
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
        int target = 25;
        // When
        int result = BinarySearch.DoBinarySearch(nums, target);
        // Then
        Assert.Equal(-1, result);
    }

    [Fact]
    public void InterpolationSearchTargetFoundReturnIndex()
    {
        // Given
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
        int target = 9;
        // When
        int result = InterpolationSearch.DoInterpolationSearch(nums, target);
        // Then
        Assert.Equal(8, result);
    }

    [Fact]
    public void InterpolationSearchTargetFoundReturnMinusOne()
    {
        // Given
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
        int target = 25;
        // When
        int result = InterpolationSearch.DoInterpolationSearch(nums, target);
        // Then
        Assert.Equal(-1, result);
    }
}
