using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Miscellaneous.DynamicProgramming
{
  /// <summary>
  /// Solves the 0/1 Knapsack Problem using dynamic programming.
  /// </summary>
  public static class KnapsackProblem
  {
    /// <summary>
    /// Solves the knapsack problem.
    /// </summary>
    /// <param name="weights">Array of weights for each item.</param>
    /// <param name="values">Array of values for each item.</param>
    /// <param name="capacity">The maximum capacity of the knapsack.</param>
    /// <returns>The maximum value achievable within the knapsack's capacity.</returns>
    public static int Solve(int[] weights, int[] values, int capacity)
    {
      int n = values.Length;
      int[,] dp = new int[n + 1, capacity + 1];

      for (int i = 1; i <= n; i++)
      {
        for (int w = 1; w <= capacity; w++)
        {
          if (weights[i - 1] <= w)
          {
            dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
          }
          else
          {
            dp[i, w] = dp[i - 1, w];
          }
        }
      }
      return dp[n, capacity];
    }
  }
}
