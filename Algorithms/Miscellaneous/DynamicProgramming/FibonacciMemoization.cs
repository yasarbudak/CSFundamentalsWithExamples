using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Miscellaneous.DynamicProgramming
{
  /// <summary>
  /// Implements Fibonacci calculation using memoization to optimize recursive calls.
  /// </summary>
  public static class FibonacciMemoization
  {
    private static Dictionary<int, int> memo = new Dictionary<int, int>();

    /// <summary>
    /// Generates the nth Fibonacci number using memoization.
    /// </summary>
    /// <param name="n">The position of the Fibonacci number to generate.</param>
    /// <returns>The nth Fibonacci number.</returns>
    public static int Fibonacci(int n)
    {
      if (n <= 1)
        return n;

      if (memo.ContainsKey(n))
        return memo[n];

      int result = Fibonacci(n - 1) + Fibonacci(n - 2);
      memo[n] = result;
      return result;
    }
  }
}
