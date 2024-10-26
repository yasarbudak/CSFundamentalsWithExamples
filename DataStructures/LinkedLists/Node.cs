using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
  /// <summary>
  /// Represents a single node in a linked list, containing data and a reference to the next node.
  /// This class is used as the building block for linked lists.
  /// </summary>
  public class Node
  {
    public int Data { get; set; }
    public Node? Next { get; set; }

    public Node(int data)
    {
      Data = data;
      Next = null;
    }
  }
}
