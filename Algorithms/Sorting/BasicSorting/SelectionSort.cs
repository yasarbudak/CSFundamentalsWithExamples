using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.BasicSorting
{
  /// <summary>
  /// Implements the Selection Sort algorithm.
  /// Selection Sort repeatedly finds the minimum element from the unsorted part and puts it at the beginning.
  /// </summary>
  public static class SelectionSort
  {
    /// <summary>
    /// Sorts an array using the Selection Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
      int n = array.Length;
      for (int i = 0; i < n - 1; i++)
      {
        int minIndex = i;
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
    }
  }
}
