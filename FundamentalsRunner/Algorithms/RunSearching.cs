using Algorithms.Searching;
using Algorithms.Searching.GraphSearch;

namespace FundamentalsRunner.Algorithms
{
  public class RunSearching
  {
    public static void Execute()
    {
      int[] array = { 10, 22, 35, 47, 53, 64, 78, 89, 95 };

      Console.WriteLine("Array:");
      PrintArray(array);

      // Testing Linear Search
      Console.WriteLine("\nLinear Search for 47:");
      int linearResult = SearchingExamples.LinearSearch(array, 47);
      Console.WriteLine(linearResult != -1 ? $"Found at index {linearResult}" : "Not found");

      // Testing Binary Search
      Console.WriteLine("\nBinary Search for 64:");
      int binaryResult = SearchingExamples.BinarySearch(array, 64);
      Console.WriteLine(binaryResult != -1 ? $"Found at index {binaryResult}" : "Not found");

      // Setting up graph for BFS and DFS
      var graph = new Dictionary<int, List<int>>
            {
                {1, new List<int> {2, 3}},
                {2, new List<int> {4, 5}},
                {3, new List<int> {6}},
                {4, new List<int>()},
                {5, new List<int> {6}},
                {6, new List<int>()}
            };

      // Testing BFS
      Console.WriteLine("\nBreadth-First Search starting from node 1:");
      BreadthFirstSearch.Traverse(graph, 1);

      // Testing DFS
      Console.WriteLine("\nDepth-First Search starting from node 1:");
      DepthFirstSearch.Traverse(graph, 1);
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
