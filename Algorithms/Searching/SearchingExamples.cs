using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
  /// <summary>
  /// Contains examples of basic searching algorithms: Linear Search and Binary Search.
  /// </summary>
  public static class SearchingExamples
  {
    /// <summary>
    /// Performs a linear search on an array.
    /// </summary>
    /// <param name="array">The array to search through.</param>
    /// <param name="target">The target value to find.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int LinearSearch(int[] array, int target)
    {
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == target)
        {
          return i;
        }
      }
      return -1;
    }

    /// <summary>
    /// Performs a binary search on a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search through.</param>
    /// <param name="target">The target value to find.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int BinarySearch(int[] array, int target)
    {
      int left = 0;
      int right = array.Length - 1;

      while (left <= right)
      {
        int mid = left + (right - left) / 2;

        if (array[mid] == target)
          return mid;

        if (array[mid] < target)
          left = mid + 1;
        else
          right = mid - 1;
      }
      return -1;
    }
  }
}
