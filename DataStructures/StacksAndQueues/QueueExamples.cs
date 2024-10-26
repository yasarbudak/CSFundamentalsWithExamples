using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StacksAndQueues
{
  /// <summary>
  /// Provides basic operations for a queue (FIFO) data structure, such as enqueueing, dequeueing,
  /// and peeking elements. A queue follows the First In, First Out (FIFO) principle.
  /// </summary>
  public class QueueExamples
  {
    private int[] elements;
    private int front;
    private int rear;
    private int maxSize;
    private int count;

    /// <summary>
    /// Initializes a queue with a fixed size.
    /// </summary>
    /// <param name="size">The maximum size of the queue.</param>
    public QueueExamples(int size)
    {
      maxSize = size;
      elements = new int[maxSize];
      front = 0;
      rear = -1;
      count = 0;
    }

    /// <summary>
    /// Adds a new element to the end of the queue.
    /// </summary>
    /// <param name="data">The data to add to the queue.</param>
    public void Enqueue(int data)
    {
      if (count == maxSize)
      {
        Console.WriteLine("Queue overflow - Cannot enqueue more elements.");
        return;
      }

      if (rear == maxSize - 1)
        rear = -1;

      elements[++rear] = data;
      count++;
    }

    /// <summary>
    /// Removes and returns the front element of the queue.
    /// </summary>
    /// <returns>The front element of the queue.</returns>
    public int Dequeue()
    {
      if (IsEmpty())
      {
        Console.WriteLine("Queue underflow - No elements to dequeue.");
        return -1;
      }

      int data = elements[front++];
      if (front == maxSize)
        front = 0;

      count--;
      return data;
    }

    /// <summary>
    /// Returns the front element of the queue without removing it.
    /// </summary>
    /// <returns>The front element of the queue.</returns>
    public int Peek()
    {
      if (IsEmpty())
      {
        Console.WriteLine("Queue is empty - No elements to peek.");
        return -1;
      }
      return elements[front];
    }

    /// <summary>
    /// Checks if the queue is empty.
    /// </summary>
    /// <returns>True if the queue is empty, otherwise false.</returns>
    public bool IsEmpty()
    {
      return count == 0;
    }
  }
}
