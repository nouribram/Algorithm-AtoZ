/*
   Algorithm Time and Space Complexity
  Time and Space Complexity are measures used to evaluate 
  the efficiency of an algorithm.

  - **Time Complexity** → How the runtime of an algorithm grows 
    with the size of the input (n).

  - **Space Complexity** → How much memory an algorithm uses 
    as input size increases.

  Big-O Notation (O) describes the **upper bound** of an algorithm’s growth rate.
*/

using System;

namespace AlgorithmComplexity
{
    class Program
    {
        // Example: O(n) — Linear Time
        static void PrintNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Example: O(n^2) — Quadratic Time
        static void PrintPairs(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine($"({i}, {j})");
                }
            }
        }

        // Example: O(1) — Constant Time
        static void PrintFirstElement(int[] arr)
        {
            Console.WriteLine(arr[0]);
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("O(1) Example:");
            PrintFirstElement(numbers);

            Console.WriteLine("\nO(n) Example:");
            PrintNumbers(5);

            Console.WriteLine("\nO(n^2) Example:");
            PrintPairs(3);
        }
    }
}

/*
  Common Time Complexities (Fast → Slow):
  
  O(1)  → Constant time  
  O(log n)  → Logarithmic  
  O(n)  → Linear  
  O(n log n)  → Log-linear  
  O(n^2)  → Quadratic  
  O(2^n)  → Exponential  
  O(n!)  → Factorial

  Common Space Complexities:
  - O(1): Uses constant extra memory (e.g., swapping two variables)
  - O(n): Uses memory proportional to input size (e.g., storing an array copy)

  Example:
  - A simple for loop → O(n) time, O(1) space
  - Nested loops → O(n²) time, O(1) space
  - Recursive algorithms → O(n) or more space due to call stack
*/
