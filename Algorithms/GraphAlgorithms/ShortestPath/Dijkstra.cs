using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GraphAlgorithms.ShortestPath
{
  /// <summary>
  /// Implements Dijkstra's algorithm to find the shortest path from a starting node to all other nodes in the graph.
  /// </summary>
  public static class Dijkstra
  {
    public static Dictionary<int, int> FindShortestPath(Dictionary<int, List<(int, int)>> graph, int start)
    {
      var distances = new Dictionary<int, int>();
      var priorityQueue = new SortedSet<(int, int)>();

      foreach (var node in graph.Keys)
      {
        distances[node] = int.MaxValue;
      }
      distances[start] = 0;
      priorityQueue.Add((0, start));

      while (priorityQueue.Count > 0)
      {
        var (currentDistance, currentNode) = priorityQueue.Min;
        priorityQueue.Remove(priorityQueue.Min);

        foreach (var (neighbor, weight) in graph[currentNode])
        {
          int distance = currentDistance + weight;
          if (distance < distances[neighbor])
          {
            priorityQueue.Remove((distances[neighbor], neighbor));
            distances[neighbor] = distance;
            priorityQueue.Add((distance, neighbor));
          }
        }
      }

      return distances;
    }
  }
}
