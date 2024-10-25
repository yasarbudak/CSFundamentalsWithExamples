using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
  /// <summary>
  /// This class provides basic operations on arrays, such as reversing,
  /// finding the minimum, and finding the maximum element, as well as summing and sorting arrays.
  /// 
  /// Arrays are a fundamental data structure that store elements in a sequential, 
  /// fixed-size block of memory. They are useful for fast access to elements using an index.
  /// </summary>
  public class ArrayExamples
  {
    /// <summary>
    /// Reverses the given array manually by swapping elements from both ends.
    /// </summary>
    /// <param name="array">The array to reverse.</param>
    /// <returns>The reversed array.</returns>
    public static int[] ReverseArray(int[] array)
    {
      int start = 0;
      int end = array.Length - 1;

      // Swap elements from both ends until start meets end
      while (start < end)
      {
        // Swap the elements
        int temp = array[start];
        array[start] = array[end];
        array[end] = temp;

        // Move pointers towards the center
        start++;
        end--;
      }

      return array;
    }

    /// <summary>
    /// Finds the smallest element in the given array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <returns>The smallest element in the array.</returns>
    public static int FindMinimum(int[] array)
    {
      int min = array[0];
      foreach (var num in array)
      {
        if (num < min)
        {
          min = num;
        }
      }
      return min;
    }

    /// <summary>
    /// Finds the largest element in the given array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <returns>The largest element in the array.</returns>
    public static int FindMaximum(int[] array)
    {
      int max = array[0];
      foreach (var num in array)
      {
        if (num > max)
        {
          max = num;
        }
      }
      return max;
    }

    /// <summary>
    /// Computes the sum of all elements in the array.
    /// </summary>
    /// <param name="array">The array whose elements will be summed.</param>
    /// <returns>The sum of the array elements.</returns>
    public static int SumArray(int[] array)
    {
      int sum = 0;
      foreach (var num in array)
      {
        sum += num;
      }
      return sum;
    }

    /// <summary>
    /// Sorts the array in ascending order using the selection sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    /// <returns>The sorted array in ascending order.</returns>
    public static int[] SelectionSort(int[] array)
    {
      int n = array.Length;

      for (int i = 0; i < n - 1; i++)
      {
        int minIndex = i;

        // Find the minimum element in the unsorted part of the array
        for (int j = i + 1; j < n; j++)
        {
          if (array[j] < array[minIndex])
          {
            minIndex = j;
          }
        }

        // Swap the found minimum element with the first element
        int temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;
      }

      return array;
    }
  }
}
