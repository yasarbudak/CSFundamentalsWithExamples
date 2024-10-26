using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching.GraphSearch
{
  /// <summary>
  /// Implements the Depth-First Search (DFS) algorithm for traversing or searching graph data structures.
  /// </summary>
  public static class DepthFirstSearch
  {
    /// <summary>
    /// Performs DFS on a graph represented by an adjacency list.
    /// </summary>
    /// <param name="graph">The graph as an adjacency list.</param>
    /// <param name="startNode">The starting node for DFS.</param>
    public static void Traverse(Dictionary<int, List<int>> graph, int startNode)
    {
      var visited = new HashSet<int>();
      Console.WriteLine("Depth-First Search starting from node " + startNode + ":");
      DFSRecursive(graph, startNode, visited);
      Console.WriteLine();
    }

    private static void DFSRecursive(Dictionary<int, List<int>> graph, int node, HashSet<int> visited)
    {
      visited.Add(node);
      Console.Write(node + " ");

      foreach (var neighbor in graph[node])
      {
        if (!visited.Contains(neighbor))
        {
          DFSRecursive(graph, neighbor, visited);
        }
      }
    }
  }
}
