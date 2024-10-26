using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.AdvancedSorting
{
  /// <summary>
  /// Implements the Merge Sort algorithm.
  /// Merge Sort is a divide and conquer algorithm that divides the array into two halves,
  /// sorts them and then merges them.
  /// </summary>
  public static class MergeSort
  {
    /// <summary>
    /// Sorts an array using the Merge Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
      if (array.Length <= 1)
        return;

      MergeSortRecursive(array, 0, array.Length - 1);
    }

    private static void MergeSortRecursive(int[] array, int left, int right)
    {
      if (left < right)
      {
        int middle = (left + right) / 2;

        MergeSortRecursive(array, left, middle);
        MergeSortRecursive(array, middle + 1, right);

        Merge(array, left, middle, right);
      }
    }

    private static void Merge(int[] array, int left, int middle, int right)
    {
      int n1 = middle - left + 1;
      int n2 = right - middle;
      int[] leftArray = new int[n1];
      int[] rightArray = new int[n2];

      for (int i = 0; i < n1; i++)
        leftArray[i] = array[left + i];
      for (int j = 0; j < n2; j++)
        rightArray[j] = array[middle + 1 + j];

      int k = left, iLeft = 0, iRight = 0;

      while (iLeft < n1 && iRight < n2)
      {
        if (leftArray[iLeft] <= rightArray[iRight])
        {
          array[k++] = leftArray[iLeft++];
        }
        else
        {
          array[k++] = rightArray[iRight++];
        }
      }

      while (iLeft < n1)
        array[k++] = leftArray[iLeft++];

      while (iRight < n2)
        array[k++] = rightArray[iRight++];
    }
  }
}
