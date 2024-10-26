using Algorithms.Sorting.AdvancedSorting;
using Algorithms.Sorting.BasicSorting;

namespace FundamentalsRunner.Algorithms
{
  public class RunSorting
  {
    public static void Execute()
    {
      int[] array = { 64, 34, 25, 12, 22, 11, 90 };

      Console.WriteLine("Original Array:");
      PrintArray(array);

      // Testing Bubble Sort
      Console.WriteLine("\nBubble Sort:");
      int[] bubbleSortArray = (int[])array.Clone();
      BubbleSort.Sort(bubbleSortArray);
      PrintArray(bubbleSortArray);

      // Testing Insertion Sort
      Console.WriteLine("\nInsertion Sort:");
      int[] insertionSortArray = (int[])array.Clone();
      InsertionSort.Sort(insertionSortArray);
      PrintArray(insertionSortArray);

      // Testing Selection Sort
      Console.WriteLine("\nSelection Sort:");
      int[] selectionSortArray = (int[])array.Clone();
      SelectionSort.Sort(selectionSortArray);
      PrintArray(selectionSortArray);

      // Testing Merge Sort
      Console.WriteLine("\nMerge Sort:");
      int[] mergeSortArray = (int[])array.Clone();
      MergeSort.Sort(mergeSortArray);
      PrintArray(mergeSortArray);

      // Testing Quick Sort
      Console.WriteLine("\nQuick Sort:");
      int[] quickSortArray = (int[])array.Clone();
      QuickSort.Sort(quickSortArray);
      PrintArray(quickSortArray);

      // Testing Heap Sort
      Console.WriteLine("\nHeap Sort:");
      int[] heapSortArray = (int[])array.Clone();
      HeapSort.Sort(heapSortArray);
      PrintArray(heapSortArray);
    }

    private static void PrintArray(int[] array)
    {
      foreach (int item in array)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine();
    }
  }
}
