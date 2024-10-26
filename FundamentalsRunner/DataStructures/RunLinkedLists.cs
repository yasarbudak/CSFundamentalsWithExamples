using DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsRunner.DataStructures
{
  public class RunLinkedLists
  {
    public static void Execute()
    {
      Console.WriteLine("Testing Linked List Operations:");

      // Creating a linked list
      LinkedListExamples linkedList = new LinkedListExamples();

      // Adding elements
      Console.WriteLine("Adding elements to the list...");
      linkedList.AddLast(10);
      linkedList.AddLast(20);
      linkedList.AddLast(30);
      linkedList.AddLast(40);
      LinkedListUtilities.PrintList(linkedList.Head);

      // Finding an element
      Console.WriteLine("Finding an element in the list (20)...");
      var foundNode = linkedList.Find(20);
      if (foundNode != null)
      {
        Console.WriteLine($"Element found: {foundNode.Data}");
      }
      else
      {
        Console.WriteLine("Element not found.");
      }

      // Removing an element
      Console.WriteLine("Removing an element from the list (30)...");
      linkedList.Remove(30);
      LinkedListUtilities.PrintList(linkedList.Head);

      // Another search test
      Console.WriteLine("Finding an element in the list (30)...");
      foundNode = linkedList.Find(30);
      if (foundNode != null)
      {
        Console.WriteLine($"Element found: {foundNode.Data}");
      }
      else
      {
        Console.WriteLine("Element not found.");
      }
    }
  }
}
