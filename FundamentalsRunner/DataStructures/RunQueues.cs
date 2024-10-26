using DataStructures.StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsRunner.DataStructures
{
  public class RunQueues
  {
    public static void Execute()
    {
      Console.WriteLine("Testing Queue Operations:");

      // Creating a queue with a fixed size
      QueueExamples queue = new QueueExamples(5);

      // Enqueuing elements to the queue
      Console.WriteLine("Enqueuing elements to the queue...");
      queue.Enqueue(10);
      queue.Enqueue(20);
      queue.Enqueue(30);
      QueueUtilities.PrintQueue(queue);

      // Peeking the front element
      Console.WriteLine("Peeking front element: " + queue.Peek());

      // Dequeuing elements from the queue
      Console.WriteLine("Dequeuing element: " + queue.Dequeue());
      Console.WriteLine("Dequeuing element: " + queue.Dequeue());
      Console.WriteLine("Dequeuing element: " + queue.Dequeue());
      Console.WriteLine("Dequeuing from empty queue: " + queue.Dequeue());
    }
  }
}
