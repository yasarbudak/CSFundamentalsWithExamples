using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StacksAndQueues
{
  /// <summary>
  /// Utility class for displaying queue elements.
  /// </summary>
  public static class QueueUtilities
  {
    /// <summary>
    /// Prints all elements in the queue from front to rear.
    /// </summary>
    /// <param name="queue">The queue to display.</param>
    public static void PrintQueue(QueueExamples queue)
    {
      Console.WriteLine("Queue elements (front to rear):");

      while (!queue.IsEmpty())
      {
        Console.WriteLine(queue.Dequeue());
      }
    }
  }
}
