using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.BasicSorting
{
  /// <summary>
  /// Implements the Bubble Sort algorithm.
  /// Bubble Sort is a simple sorting algorithm that repeatedly steps through the list,
  /// compares adjacent elements and swaps them if they are in the wrong order.
  /// </summary>
  public static class BubbleSort
  {
    /// <summary>
    /// Sorts an array using the Bubble Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
      int n = array.Length;
      for (int i = 0; i < n - 1; i++)
      {
        for (int j = 0; j < n - i - 1; j++)
        {
          if (array[j] > array[j + 1])
          {
            // Swap if the current element is greater than the next element
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
          }
        }
      }
    }
  }
}
