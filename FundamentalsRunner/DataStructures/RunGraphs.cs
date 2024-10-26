using DataStructures.TreesAndGraphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsRunner.DataStructures
{
  public class RunGraphs
  {
    public static void Execute()
    {
      Console.WriteLine("Testing Graph Operations:");

      // Creating a graph
      GraphExamples graph = new GraphExamples();

      // Adding nodes and edges
      graph.AddNode(1);
      graph.AddNode(2);
      graph.AddEdge(1, 2);
      graph.AddEdge(1, 3);
      graph.AddEdge(2, 4);
      graph.AddEdge(3, 4);
      graph.AddEdge(4, 5);

      // Displaying the graph
      Console.WriteLine("Displaying the graph:");
      graph.DisplayGraph();

      // Performing BFS and DFS traversals
      Console.WriteLine("Breadth-First Search from node 1:");
      graph.BreadthFirstSearch(1);

      Console.WriteLine("Depth-First Search from node 1:");
      graph.DepthFirstSearch(1);
    }
  }
}
