using DataStructures.TreesAndGraphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsRunner.DataStructures
{
  public class RunTrees
  {
    public static void Execute()
    {
      Console.WriteLine("Testing Binary Tree Operations:");

      // Creating a binary tree
      TreeExamples binaryTree = new TreeExamples();

      // Inserting elements
      Console.WriteLine("Inserting elements into the tree...");
      binaryTree.Insert(50);
      binaryTree.Insert(30);
      binaryTree.Insert(70);
      binaryTree.Insert(20);
      binaryTree.Insert(40);
      binaryTree.Insert(60);
      binaryTree.Insert(80);

      // InOrder Traversal
      Console.WriteLine("InOrder Traversal of the tree:");
      binaryTree.InOrderTraversal();

      // PreOrder Traversal
      Console.WriteLine("PreOrder Traversal of the tree:");
      binaryTree.PreOrderTraversal();

      // PostOrder Traversal
      Console.WriteLine("PostOrder Traversal of the tree:");
      binaryTree.PostOrderTraversal();

      // LevelOrder Traversal
      Console.WriteLine("LevelOrder Traversal of the tree:");
      binaryTree.LevelOrderTraversal();

      // Searching for elements
      Console.WriteLine("Searching for 40 in the tree: " + (binaryTree.Search(40) ? "Found" : "Not Found"));
      Console.WriteLine("Searching for 90 in the tree: " + (binaryTree.Search(90) ? "Found" : "Not Found"));
    }
  }
}
