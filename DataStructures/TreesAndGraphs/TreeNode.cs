using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.TreesAndGraphs
{
  /// <summary>
  /// Represents a single node in a binary tree, containing data and references to left and right child nodes.
  /// This class is used as the building block for binary trees.
  /// </summary>
  public class TreeNode
  {
    public int Data { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int data)
    {
      Data = data;
      Left = null;
      Right = null;
    }
  }
}
