# CSharpFundamentalsWithExamples

This project, **CSharpFundamentalsWithExamples**, provides an in-depth exploration of fundamental data structures and algorithms using C#. It includes examples for understanding basic to advanced concepts, with a focus on improving algorithmic thinking and hands-on coding practice. 

## Project Structure

The project is organized into distinct sections based on the type of data structure or algorithm:

### 1. Data Structures
- **Arrays** - Basic operations on arrays, including iteration, insertion, and deletion.
- **Linked Lists** - Implementation of singly and doubly linked lists.
- **Stacks** - LIFO data structure with operations like push, pop, and peek.
- **Queues** - FIFO data structure with enqueue and dequeue operations.
- **Trees** - Binary trees and traversal techniques (preorder, inorder, and postorder).
- **Graphs** - Basic graph operations and adjacency list representation.

### 2. Algorithms
- **Sorting Algorithms**:
  - Basic Sorting: Bubble Sort, Selection Sort, and Insertion Sort.
  - Advanced Sorting: Merge Sort, Quick Sort, and Heap Sort.
- **Searching Algorithms**:
  - Linear Search, Binary Search.
  - Graph Search: Breadth-First Search (BFS) and Depth-First Search (DFS).
- **Graph Algorithms**:
  - Shortest Path: Dijkstra’s Algorithm, Bellman-Ford Algorithm.
  - Minimum Spanning Tree: Kruskal’s Algorithm, Prim’s Algorithm.
- **Miscellaneous Algorithms**:
  - Factorial Calculation, Fibonacci Sequence.
  - Dynamic Programming: Knapsack Problem, Longest Common Subsequence (LCS).

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yasarbudak/CSharpFundamentalsWithExamples.git
2.	Navigate to the project directory:
bash
Copy code
cd CSharpFundamentalsWithExamples
3.	Open the project in Visual Studio or your preferred C# IDE.
Usage
Each data structure and algorithm has been implemented as a separate class and is callable through the ExampleRunner class, which provides a menu for running various examples.
1.	Run the ExampleRunner: Execute the ExampleRunner to view the available options.
2.	Select a data structure or algorithm: Follow the prompts to choose an example and see the outputs of each operation.
Sample Code Usage
Example: Running Bubble Sort
csharp
Copy code
using Algorithms.Sorting.BasicSorting;

int[] array = { 64, 34, 25, 12, 22, 11, 90 };
BubbleSort.Sort(array);

foreach (int item in array)
{
    Console.Write(item + " ");
}
Example: Finding Shortest Path with Dijkstra’s Algorithm
csharp
Copy code
using Algorithms.GraphAlgorithms.ShortestPath;

var graph = new Dictionary<int, List<(int, int)>>
{
    { 0, new List<(int, int)> { (1, 4), (2, 1) } },
    { 1, new List<(int, int)> { (3, 1) } },
    { 2, new List<(int, int)> { (1, 2), (3, 5) } },
    { 3, new List<(int, int)>() }
};

var result = Dijkstra.FindShortestPath(graph, 0);
foreach (var (node, distance) in result)
{
    Console.WriteLine($"Distance from node 0 to node {node}: {distance}");
}

## Contributing
Contributions are welcome! If you have suggestions for additional examples or improvements, please feel free to fork the repository and submit a pull request.
1.	Fork the repository.
2.	Create a new branch for your feature (git checkout -b feature/AmazingFeature).
3.	Commit your changes (git commit -m 'Add some AmazingFeature').
4.	Push to the branch (git push origin feature/AmazingFeature).
5.	Open a pull request.
    
## License
Distributed under the MIT License. See LICENSE for more information.

