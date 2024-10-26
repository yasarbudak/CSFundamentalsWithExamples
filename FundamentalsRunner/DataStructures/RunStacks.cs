using DataStructures.StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsRunner.DataStructures
{
  public class RunStacks
  {
    public static void Execute()
    {
      Console.WriteLine("Testing Stack Operations:");

      // Creating a stack with a fixed size
      StackExamples stack = new StackExamples(5);

      // Pushing elements onto the stack
      Console.WriteLine("Pushing elements onto the stack...");
      stack.Push(10);
      stack.Push(20);
      stack.Push(30);
      StackUtilities.PrintStack(stack);

      // Peeking the top element
      Console.WriteLine("Peeking top element: " + stack.Peek());

      // Popping elements from the stack
      Console.WriteLine("Popping element: " + stack.Pop());
      Console.WriteLine("Popping element: " + stack.Pop());
      Console.WriteLine("Popping element: " + stack.Pop());
      Console.WriteLine("Popping from empty stack: " + stack.Pop());
    }
  }
}
