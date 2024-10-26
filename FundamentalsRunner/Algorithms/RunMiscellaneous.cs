using Algorithms.Miscellaneous.DynamicProgramming;
using Algorithms.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsRunner.Algorithms
{
  public class RunMiscellaneous
  {
    public static void Execute()
    {
      // Testing Factorial
      Console.WriteLine("Factorial of 5:");
      int factorialResult = MiscAlgorithms.Factorial(5);
      Console.WriteLine(factorialResult);

      // Testing Fibonacci
      Console.WriteLine("\nFibonacci of 10:");
      int fibonacciResult = MiscAlgorithms.Fibonacci(10);
      Console.WriteLine(fibonacciResult);

      // Testing Fibonacci with Memoization
      Console.WriteLine("\nFibonacci with Memoization of 10:");
      int fibonacciMemoResult = FibonacciMemoization.Fibonacci(10);
      Console.WriteLine(fibonacciMemoResult);

      // Testing Knapsack Problem
      Console.WriteLine("\nKnapsack Problem:");
      int[] weights = { 2, 3, 4, 5 };
      int[] values = { 3, 4, 5, 6 };
      int capacity = 5;
      int knapsackResult = KnapsackProblem.Solve(weights, values, capacity);
      Console.WriteLine($"Maximum value within capacity {capacity}: {knapsackResult}");

      // Testing Longest Common Subsequence (LCS)
      Console.WriteLine("\nLongest Common Subsequence:");
      string str1 = "AGGTAB";
      string str2 = "GXTXAYB";
      int lcsResult = LongestCommonSubsequence.CalculateLCS(str1, str2);
      Console.WriteLine($"Length of LCS between \"{str1}\" and \"{str2}\": {lcsResult}");
    }
  }
}
