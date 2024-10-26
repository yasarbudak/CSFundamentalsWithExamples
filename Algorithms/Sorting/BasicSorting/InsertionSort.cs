using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.BasicSorting
{
  /// <summary>
  /// Implements the Insertion Sort algorithm.
  /// Insertion Sort builds the final sorted array one item at a time.
  /// </summary>
  public static class InsertionSort
  {
    /// <summary>
    /// Sorts an array using the Insertion Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
      int n = array.Length;
      for (int i = 1; i < n; i++)
      {
        int key = array[i];
        int j = i - 1;

        // Move elements of array[0...i-1], that are greater than key, to one position ahead of their current position
        while (j >= 0 && array[j] > key)
        {
          array[j + 1] = array[j];
          j = j - 1;
        }
        array[j + 1] = key;
      }
    }
  }
}
