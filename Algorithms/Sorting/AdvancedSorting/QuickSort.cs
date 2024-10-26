using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.AdvancedSorting
{
  /// <summary>
  /// Implements the Quick Sort algorithm.
  /// Quick Sort is a divide and conquer algorithm that picks an element as pivot,
  /// partitions the array around the pivot and sorts recursively.
  /// </summary>
  public static class QuickSort
  {
    /// <summary>
    /// Sorts an array using the Quick Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
      QuickSortRecursive(array, 0, array.Length - 1);
    }

    private static void QuickSortRecursive(int[] array, int low, int high)
    {
      if (low < high)
      {
        int pivotIndex = Partition(array, low, high);

        QuickSortRecursive(array, low, pivotIndex - 1);
        QuickSortRecursive(array, pivotIndex + 1, high);
      }
    }

    private static int Partition(int[] array, int low, int high)
    {
      int pivot = array[high];
      int i = low - 1;

      for (int j = low; j < high; j++)
      {
        if (array[j] < pivot)
        {
          i++;
          Swap(array, i, j);
        }
      }

      Swap(array, i + 1, high);
      return i + 1;
    }

    private static void Swap(int[] array, int i, int j)
    {
      int temp = array[i];
      array[i] = array[j];
      array[j] = temp;
    }
  }
}
