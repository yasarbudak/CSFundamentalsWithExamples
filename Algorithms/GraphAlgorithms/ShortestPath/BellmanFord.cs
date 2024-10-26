using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GraphAlgorithms.ShortestPath
{
  /// <summary>
  /// Implements Bellman-Ford algorithm to find the shortest path from a starting node to all other nodes in the graph,
  /// and detects if there's a negative cycle.
  /// </summary>
  public static class BellmanFord
  {
    public static Dictionary<int, int> FindShortestPath(Dictionary<int, List<(int, int)>> graph, int start, int vertices)
    {
      var distances = new Dictionary<int, int>();

      foreach (var node in graph.Keys)
      {
        distances[node] = int.MaxValue;
      }
      distances[start] = 0;

      for (int i = 0; i < vertices - 1; i++)
      {
        foreach (var (node, edges) in graph)
        {
          foreach (var (neighbor, weight) in edges)
          {
            if (distances[node] != int.MaxValue && distances[node] + weight < distances[neighbor])
            {
              distances[neighbor] = distances[node] + weight;
            }
          }
        }
      }

      foreach (var (node, edges) in graph)
      {
        foreach (var (neighbor, weight) in edges)
        {
          if (distances[node] != int.MaxValue && distances[node] + weight < distances[neighbor])
          {
            throw new InvalidOperationException("Graph contains a negative-weight cycle");
          }
        }
      }

      return distances;
    }
  }
}
