using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GraphAlgorithms.MinimumSpanningTree
{
  /// <summary>
  /// Implements Prim's algorithm to find the Minimum Spanning Tree (MST) of a graph.
  /// </summary>
  public static class Prim
  {
    public static int FindMST(int vertices, Dictionary<int, List<(int, int)>> graph)
    {
      var visited = new HashSet<int>();
      var priorityQueue = new SortedSet<(int, int, int)>();
      int mstCost = 0;

      priorityQueue.Add((0, -1, 0)); // (cost, from, to)

      while (visited.Count < vertices)
      {
        var (cost, from, to) = priorityQueue.Min;
        priorityQueue.Remove(priorityQueue.Min);

        if (visited.Contains(to))
          continue;

        visited.Add(to);
        mstCost += cost;

        foreach (var (neighbor, weight) in graph[to])
        {
          if (!visited.Contains(neighbor))
            priorityQueue.Add((weight, to, neighbor));
        }
      }

      return mstCost;
    }
  }
}
