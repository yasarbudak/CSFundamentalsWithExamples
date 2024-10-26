using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Miscellaneous.DynamicProgramming
{
  /// <summary>
  /// Finds the Longest Common Subsequence (LCS) between two strings using dynamic programming.
  /// </summary>
  public static class LongestCommonSubsequence
  {
    /// <summary>
    /// Calculates the length of the longest common subsequence between two strings.
    /// </summary>
    /// <param name="str1">The first string.</param>
    /// <param name="str2">The second string.</param>
    /// <returns>The length of the longest common subsequence.</returns>
    public static int CalculateLCS(string str1, string str2)
    {
      int m = str1.Length;
      int n = str2.Length;
      int[,] dp = new int[m + 1, n + 1];

      for (int i = 1; i <= m; i++)
      {
        for (int j = 1; j <= n; j++)
        {
          if (str1[i - 1] == str2[j - 1])
          {
            dp[i, j] = dp[i - 1, j - 1] + 1;
          }
          else
          {
            dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
          }
        }
      }
      return dp[m, n];
    }
  }
}
