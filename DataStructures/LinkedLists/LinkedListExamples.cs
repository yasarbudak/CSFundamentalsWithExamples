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
  /// <summary>
  /// Provides basic operations for a singly linked list, such as adding, removing, and finding nodes.
  /// Linked lists are dynamic data structures that allow efficient insertion and deletion operations.
  /// Each node points to the next node in the sequence, forming a chain of elements.
  /// </summary>
  public class LinkedListExamples
  {
    public Node Head { get; private set; }

    public LinkedListExamples()
    {
      Head = null;
    }

    /// <summary>
    /// Adds a new node with the specified data at the end of the list.
    /// </summary>
    /// <param name="data">The data to add to the list.</param>
    public void AddLast(int data)
    {
      Node newNode = new Node(data);
      if (Head == null)
      {
        Head = newNode;
      }
      else
      {
        Node current = Head;
        while (current.Next != null)
        {
          current = current.Next;
        }
        current.Next = newNode;
      }
    }

    /// <summary>
    /// Removes the first occurrence of a node with the specified data.
    /// </summary>
    /// <param name="data">The data of the node to remove.</param>
    public void Remove(int data)
    {
      if (Head == null) return;

      if (Head.Data == data)
      {
        Head = Head.Next;
        return;
      }

      Node current = Head;
      while (current.Next != null)
      {
        if (current.Next.Data == data)
        {
          current.Next = current.Next.Next;
          return;
        }
        current = current.Next;
      }
    }

    /// <summary>
    /// Finds the first node with the specified data.
    /// </summary>
    /// <param name="data">The data to search for.</param>
    /// <returns>The node containing the data, or null if not found.</returns>
    public Node? Find(int data)
    {
      Node current = Head;
      while (current != null)
      {
        if (current.Data == data)
          return current;
        current = current.Next;
      }
      return null;
    }
  }
}
