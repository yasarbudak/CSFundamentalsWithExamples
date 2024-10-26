using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StacksAndQueues
{
  /// <summary>
  /// Provides basic operations for a stack (LIFO) data structure, such as pushing, popping,
  /// and peeking elements. A stack follows the Last In, First Out (LIFO) principle.
  /// </summary>
  public class StackExamples
  {
    private int[] elements;
    private int top;
    private int maxSize;

    /// <summary>
    /// Initializes a stack with a fixed size.
    /// </summary>
    /// <param name="size">The maximum size of the stack.</param>
    public StackExamples(int size)
    {
      maxSize = size;
      elements = new int[maxSize];
      top = -1;
    }

    /// <summary>
    /// Adds a new element to the top of the stack.
    /// </summary>
    /// <param name="data">The data to add to the stack.</param>
    public void Push(int data)
    {
      if (top == maxSize - 1)
      {
        Console.WriteLine("Stack overflow - Cannot push more elements.");
        return;
      }
      elements[++top] = data;
    }

    /// <summary>
    /// Removes and returns the top element of the stack.
    /// </summary>
    /// <returns>The top element of the stack.</returns>
    public int Pop()
    {
      if (IsEmpty())
      {
        Console.WriteLine("Stack underflow - No elements to pop.");
        return -1;
      }
      return elements[top--];
    }

    /// <summary>
    /// Returns the top element of the stack without removing it.
    /// </summary>
    /// <returns>The top element of the stack.</returns>
    public int Peek()
    {
      if (IsEmpty())
      {
        Console.WriteLine("Stack is empty - No elements to peek.");
        return -1;
      }
      return elements[top];
    }

    /// <summary>
    /// Checks if the stack is empty.
    /// </summary>
    /// <returns>True if the stack is empty, otherwise false.</returns>
    public bool IsEmpty()
    {
      return top == -1;
    }
  }
}
