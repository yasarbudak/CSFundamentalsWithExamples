using Algorithms.GraphAlgorithms.MinimumSpanningTree;
using Algorithms.GraphAlgorithms.ShortestPath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsRunner.Algorithms
{
  public class RunGraphAlgorithms
  {
    public static void Execute()
    {
      // Shortest Path - Dijkstra's Algorithm
      Console.WriteLine("Dijkstra's Algorithm (Shortest Path):");
      var graph = new Dictionary<int, List<(int, int)>>
            {
                { 0, new List<(int, int)> { (1, 4), (2, 1) } },
                { 1, new List<(int, int)> { (3, 1) } },
                { 2, new List<(int, int)> { (1, 2), (3, 5) } },
                { 3, new List<(int, int)>() }
            };
      var dijkstraResult = Dijkstra.FindShortestPath(graph, 0);
      foreach (var (node, distance) in dijkstraResult)
      {
        Console.WriteLine($"Distance from node 0 to node {node}: {distance}");
      }

      // Shortest Path - Bellman-Ford Algorithm
      Console.WriteLine("\nBellman-Ford Algorithm (Shortest Path):");
      var bellmanFordResult = BellmanFord.FindShortestPath(graph, 0, graph.Count);
      foreach (var (node, distance) in bellmanFordResult)
      {
        Console.WriteLine($"Distance from node 0 to node {node}: {distance}");
      }

      // Minimum Spanning Tree - Kruskal's Algorithm
      Console.WriteLine("\nKruskal's Algorithm (Minimum Spanning Tree):");
      var edges = new List<(int, int, int)>
            {
                (0, 1, 4), (0, 2, 1), (1, 3, 1), (2, 1, 2), (2, 3, 5)
            };
      var kruskalResult = Kruskal.FindMST(graph.Count, edges);
      foreach (var (u, v, weight) in kruskalResult)
      {
        Console.WriteLine($"Edge ({u}, {v}) with weight {weight}");
      }

      // Minimum Spanning Tree - Prim's Algorithm
      Console.WriteLine("\nPrim's Algorithm (Minimum Spanning Tree):");
      int primResult = Prim.FindMST(graph.Count, graph);
      Console.WriteLine($"Total cost of MST using Prim's algorithm: {primResult}");
    }
  }
}
