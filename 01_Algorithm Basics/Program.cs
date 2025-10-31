/*
  Algorithm Basics & Properties
  An algorithm is a step-by-step set of instructions designed to perform a specific task or solve a problem.
  In programming, algorithms are essential for problem-solving, optimization, and efficient software design.
*/

using System;

namespace CSharpTutorial
{
    class Algorithm_Basics
    {
        static void Main(string[] args)
        {
            /*
              WHAT IS AN ALGORITHM?
              ----------------------
              An algorithm is:
              - A sequence of well-defined steps.
              - A method to transform input into output.
              - The foundation of all programming and computation.

              Example: Algorithm to find the largest number in an array.
            */

            int[] numbers = { 5, 12, 3, 19, 7 };
            int max = FindMax(numbers);

            Console.WriteLine("The largest number is: " + max);

            /*
              PROPERTIES OF A GOOD ALGORITHM
              ------------------------------
              1. Input — The algorithm should have well-defined input(s).
              2. Output — The algorithm should produce a clear, expected result.
              3. Definiteness — Each step must be clearly and unambiguously defined.
              4. Finiteness — The algorithm must terminate after a finite number of steps.
              5. Effectiveness — Each operation must be simple enough to execute.
              6. Generality — The algorithm should be applicable to a class of problems, not just one case.
            */

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Algorithm Properties:");
            Console.WriteLine("1. Input: Clearly defined starting data");
            Console.WriteLine("2. Output: Specific and expected result");
            Console.WriteLine("3. Definiteness: Unambiguous steps");
            Console.WriteLine("4. Finiteness: Ends after limited steps");
            Console.WriteLine("5. Effectiveness: Simple to execute");
            Console.WriteLine("6. Generality: Solves similar problems");
            Console.WriteLine("-----------------------------");

            /*
              TYPES OF ALGORITHMS
              -------------------
              - Searching (e.g., Linear Search, Binary Search)
              - Sorting (e.g., Bubble Sort, Quick Sort)
              - Recursive Algorithms
              - Divide and Conquer
              - Dynamic Programming
              - Greedy Algorithms
            */

            Console.WriteLine("Common Algorithm Categories:");
            Console.WriteLine("- Searching");
            Console.WriteLine("- Sorting");
            Console.WriteLine("- Recursion");
            Console.WriteLine("- Divide & Conquer");
            Console.WriteLine("- Dynamic Programming");
            Console.WriteLine("- Greedy Algorithms");
        }

        /*
          EXAMPLE ALGORITHM IMPLEMENTATION:
          Finding the maximum number in an array.
          This algorithm demonstrates basic principles:
          - Clear input (array)
          - Clear output (max value)
          - Finite and simple steps
        */
        static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}

/*
  SUMMARY:
  ----------
  Algorithm = Step-by-step process to solve a problem.
  Key Properties = Input, Output, Definiteness, Finiteness, Effectiveness, Generality.
  Example: Finding the largest number in an array.
  Good algorithms are efficient, clear, and reusable.
*/
