using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching.GraphSearch
{
  /// <summary>
  /// Implements the Breadth-First Search (BFS) algorithm for traversing or searching graph data structures.
  /// </summary>
  public static class BreadthFirstSearch
  {
    /// <summary>
    /// Performs BFS on a graph represented by an adjacency list.
    /// </summary>
    /// <param name="graph">The graph as an adjacency list.</param>
    /// <param name="startNode">The starting node for BFS.</param>
    public static void Traverse(Dictionary<int, List<int>> graph, int startNode)
    {
      var visited = new HashSet<int>();
      var queue = new Queue<int>();
      visited.Add(startNode);
      queue.Enqueue(startNode);

      Console.WriteLine("Breadth-First Search starting from node " + startNode + ":");

      while (queue.Count > 0)
      {
        int node = queue.Dequeue();
        Console.Write(node + " ");

        foreach (var neighbor in graph[node])
        {
          if (!visited.Contains(neighbor))
          {
            visited.Add(neighbor);
            queue.Enqueue(neighbor);
          }
        }
      }
      Console.WriteLine();
    }
  }
}
