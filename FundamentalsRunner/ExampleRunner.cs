using FundamentalsRunner.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsRunner
{
  public class ExampleRunner
  {
    public void Run()
    {
      while (true)
      {
        Console.Clear();
        Console.WriteLine("Choose an example to run:");
        Console.WriteLine("1. Array Examples");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            RunArrays.Execute();
            break;
          case "0":
            Console.WriteLine("Exiting...");
            return;
          default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
        }

        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
      }
    }
  }
}
