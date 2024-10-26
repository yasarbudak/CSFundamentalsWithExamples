using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StacksAndQueues
{
  /// <summary>
  /// Utility class for displaying stack elements.
  /// </summary>
  public static class StackUtilities
  {
    /// <summary>
    /// Prints all elements in the stack from top to bottom.
    /// </summary>
    /// <param name="stack">The stack to display.</param>
    public static void PrintStack(StackExamples stack)
    {
      Console.WriteLine("Stack elements (top to bottom):");

      while (!stack.IsEmpty())
      {
        Console.WriteLine(stack.Pop());
      }
    }
  }
}
