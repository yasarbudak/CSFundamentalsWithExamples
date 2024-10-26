using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.AdvancedSorting
{
  /// <summary>
  /// Implements the Heap Sort algorithm.
  /// Heap Sort is a comparison-based sorting algorithm that uses a binary heap data structure.
  /// </summary>
  public static class HeapSort
  {
    /// <summary>
    /// Sorts an array using the Heap Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
      int n = array.Length;

      // Build max heap
      for (int i = n / 2 - 1; i >= 0; i--)
        Heapify(array, n, i);

      // Extract elements from heap one by one
      for (int i = n - 1; i > 0; i--)
      {
        // Move current root to end
        int temp = array[0];
        array[0] = array[i];
        array[i] = temp;

        // call max heapify on the reduced heap
        Heapify(array, i, 0);
      }
    }

    private static void Heapify(int[] array, int n, int i)
    {
      int largest = i;
      int left = 2 * i + 1;
      int right = 2 * i + 2;

      if (left < n && array[left] > array[largest])
        largest = left;

      if (right < n && array[right] > array[largest])
        largest = right;

      if (largest != i)
      {
        int swap = array[i];
        array[i] = array[largest];
        array[largest] = swap;

        // Recursively heapify the affected sub-tree
        Heapify(array, n, largest);
      }
    }
  }
}
