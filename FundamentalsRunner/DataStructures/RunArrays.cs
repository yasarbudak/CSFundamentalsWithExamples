using DataStructures.Arrays;

namespace FundamentalsRunner.DataStructures
{
  public class RunArrays
  {
    public static void Execute()
    {
      // Test data: Sample array
      int[] array = { 3, 5, 1, 8, 9, 2 };

      Console.WriteLine("Original Array: " + string.Join(", ", array));

      // 1. Reverse the array manually
      int[] reversedArray = ArrayExamples.ReverseArray(array);
      Console.WriteLine("Reversed Array: " + string.Join(", ", reversedArray));

      // 2. Find the smallest element
      int min = ArrayExamples.FindMinimum(array);
      Console.WriteLine("Minimum Element: " + min);

      // 3. Find the largest element
      int max = ArrayExamples.FindMaximum(array);
      Console.WriteLine("Maximum Element: " + max);

      // 4. Compute the sum of the array elements
      int sum = ArrayExamples.SumArray(array);
      Console.WriteLine("Sum of Array Elements: " + sum);

      // 5. Sort the array using Selection Sort
      int[] sortedArray = ArrayExamples.SelectionSort(array);
      Console.WriteLine("Sorted Array: " + string.Join(", ", sortedArray));
    }
  }
}
