using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Miscellaneous
{
  /// <summary>
  /// Contains miscellaneous mathematical algorithms, such as calculating factorial and generating Fibonacci sequence.
  /// </summary>
  public static class MiscAlgorithms
  {
    /// <summary>
    /// Calculates the factorial of a given number using recursion.
    /// </summary>
    /// <param name="n">The number to calculate the factorial for.</param>
    /// <returns>The factorial of the given number.</returns>
    public static int Factorial(int n)
    {
      if (n <= 1)
        return 1;
      return n * Factorial(n - 1);
    }

    /// <summary>
    /// Generates the nth Fibonacci number using recursion.
    /// </summary>
    /// <param name="n">The position of the Fibonacci number to generate.</param>
    /// <returns>The nth Fibonacci number.</returns>
    public static int Fibonacci(int n)
    {
      if (n <= 1)
        return n;
      return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
  }
}
