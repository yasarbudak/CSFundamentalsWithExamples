using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.TreesAndGraphs
{
  /// <summary>
  /// Provides basic operations for a binary tree, such as inserting, searching, and traversing nodes.
  /// A binary tree is a hierarchical data structure where each node has at most two children.
  /// </summary>
  public class TreeExamples
  {
    public TreeNode Root { get; private set; }

    public TreeExamples()
    {
      Root = null;
    }

    /// <summary>
    /// Inserts a new node with the specified data into the binary tree.
    /// </summary>
    /// <param name="data">The data to insert into the tree.</param>
    public void Insert(int data)
    {
      Root = InsertRecursively(Root, data);
    }

    private TreeNode InsertRecursively(TreeNode node, int data)
    {
      if (node == null)
      {
        node = new TreeNode(data);
        return node;
      }

      if (data < node.Data)
        node.Left = InsertRecursively(node.Left, data);
      else if (data > node.Data)
        node.Right = InsertRecursively(node.Right, data);

      return node;
    }

    /// <summary>
    /// Searches for a node with the specified data in the binary tree.
    /// </summary>
    /// <param name="data">The data to search for.</param>
    /// <returns>True if the data is found, otherwise false.</returns>
    public bool Search(int data)
    {
      return SearchRecursively(Root, data);
    }

    private bool SearchRecursively(TreeNode node, int data)
    {
      if (node == null)
        return false;

      if (node.Data == data)
        return true;

      if (data < node.Data)
        return SearchRecursively(node.Left, data);

      return SearchRecursively(node.Right, data);
    }

    /// <summary>
    /// Traverses the tree in an inorder fashion and prints each node's data.
    /// </summary>
    public void InOrderTraversal()
    {
      InOrderTraversalRecursively(Root);
      Console.WriteLine();
    }

    private void InOrderTraversalRecursively(TreeNode node)
    {
      if (node != null)
      {
        InOrderTraversalRecursively(node.Left);
        Console.Write(node.Data + " ");
        InOrderTraversalRecursively(node.Right);
      }
    }

    /// <summary>
    /// Traverses the tree in a preorder fashion and prints each node's data.
    /// </summary>
    public void PreOrderTraversal()
    {
      PreOrderTraversalRecursively(Root);
      Console.WriteLine();
    }

    private void PreOrderTraversalRecursively(TreeNode node)
    {
      if (node != null)
      {
        Console.Write(node.Data + " ");
        PreOrderTraversalRecursively(node.Left);
        PreOrderTraversalRecursively(node.Right);
      }
    }

    /// <summary>
    /// Traverses the tree in a postorder fashion and prints each node's data.
    /// </summary>
    public void PostOrderTraversal()
    {
      PostOrderTraversalRecursively(Root);
      Console.WriteLine();
    }

    private void PostOrderTraversalRecursively(TreeNode node)
    {
      if (node != null)
      {
        PostOrderTraversalRecursively(node.Left);
        PostOrderTraversalRecursively(node.Right);
        Console.Write(node.Data + " ");
      }
    }

    /// <summary>
    /// Traverses the tree in a level order fashion and prints each node's data.
    /// </summary>
    public void LevelOrderTraversal()
    {
      if (Root == null) return;

      Queue<TreeNode> queue = new Queue<TreeNode>();
      queue.Enqueue(Root);

      while (queue.Count > 0)
      {
        TreeNode currentNode = queue.Dequeue();
        Console.Write(currentNode.Data + " ");

        if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
        if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
      }
      Console.WriteLine();
    }
  }
}
