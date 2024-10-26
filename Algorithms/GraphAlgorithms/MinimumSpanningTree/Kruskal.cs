using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GraphAlgorithms.MinimumSpanningTree
{
  /// <summary>
  /// Implements Kruskal's algorithm to find the Minimum Spanning Tree (MST) of a graph.
  /// </summary>
  public static class Kruskal
  {
    public static List<(int, int, int)> FindMST(int vertices, List<(int, int, int)> edges)
    {
      edges.Sort((a, b) => a.Item3.CompareTo(b.Item3));
      var mst = new List<(int, int, int)>();
      var parent = new int[vertices];

      for (int i = 0; i < vertices; i++)
        parent[i] = i;

      int Find(int v)
      {
        if (parent[v] == v)
          return v;
        return parent[v] = Find(parent[v]);
      }

      void Union(int u, int v)
      {
        parent[Find(u)] = Find(v);
      }

      foreach (var (u, v, weight) in edges)
      {
        if (Find(u) != Find(v))
        {
          mst.Add((u, v, weight));
          Union(u, v);
        }
      }

      return mst;
    }
  }
}
