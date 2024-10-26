using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
  /// <summary>
  /// Utility class for printing and displaying linked list content.
  /// </summary>
  public static class LinkedListUtilities
  {
    /// <summary>
    /// Prints all elements in the linked list to the console.
    /// </summary>
    /// <param name="head">The head node of the linked list.</param>
    public static void PrintList(Node head)
    {
      Node current = head;
      while (current != null)
      {
        Console.Write(current.Data + " -> ");
        current = current.Next;
      }
      Console.WriteLine("null");
    }
  }
}
