using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.TreesAndGraphs
{
  /// <summary>
  /// Represents an undirected graph using adjacency lists, providing basic operations
  /// such as adding nodes, adding edges, and traversing the graph.
  /// </summary>
  public class GraphExamples
  {
    private Dictionary<int, List<int>> adjacencyList;

    public GraphExamples()
    {
      adjacencyList = new Dictionary<int, List<int>>();
    }

    /// <summary>
    /// Adds a node to the graph.
    /// </summary>
    /// <param name="node">The node to add to the graph.</param>
    public void AddNode(int node)
    {
      if (!adjacencyList.ContainsKey(node))
      {
        adjacencyList[node] = new List<int>();
      }
    }

    /// <summary>
    /// Adds an undirected edge between two nodes in the graph.
    /// </summary>
    /// <param name="node1">The first node.</param>
    /// <param name="node2">The second node.</param>
    public void AddEdge(int node1, int node2)
    {
      if (!adjacencyList.ContainsKey(node1))
        AddNode(node1);

      if (!adjacencyList.ContainsKey(node2))
        AddNode(node2);

      adjacencyList[node1].Add(node2);
      adjacencyList[node2].Add(node1);
    }

    /// <summary>
    /// Displays all nodes and their adjacent nodes in the graph.
    /// </summary>
    public void DisplayGraph()
    {
      Console.WriteLine("Graph adjacency list:");
      foreach (var node in adjacencyList)
      {
        Console.Write(node.Key + ": ");
        foreach (var neighbor in node.Value)
        {
          Console.Write(neighbor + " ");
        }
        Console.WriteLine();
      }
    }

    /// <summary>
    /// Performs a breadth-first search (BFS) traversal starting from the specified node.
    /// </summary>
    /// <param name="startNode">The starting node for BFS traversal.</param>
    public void BreadthFirstSearch(int startNode)
    {
      var visited = new HashSet<int>();
      var queue = new Queue<int>();

      visited.Add(startNode);
      queue.Enqueue(startNode);

      Console.WriteLine("Breadth-First Search (BFS) starting from node " + startNode + ":");

      while (queue.Count > 0)
      {
        int currentNode = queue.Dequeue();
        Console.Write(currentNode + " ");

        foreach (var neighbor in adjacencyList[currentNode])
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

    /// <summary>
    /// Performs a depth-first search (DFS) traversal starting from the specified node.
    /// </summary>
    /// <param name="startNode">The starting node for DFS traversal.</param>
    public void DepthFirstSearch(int startNode)
    {
      var visited = new HashSet<int>();

      Console.WriteLine("Depth-First Search (DFS) starting from node " + startNode + ":");
      DepthFirstSearchRecursively(startNode, visited);
      Console.WriteLine();
    }

    private void DepthFirstSearchRecursively(int node, HashSet<int> visited)
    {
      visited.Add(node);
      Console.Write(node + " ");

      foreach (var neighbor in adjacencyList[node])
      {
        if (!visited.Contains(neighbor))
        {
          DepthFirstSearchRecursively(neighbor, visited);
        }
      }
    }
  }
}
