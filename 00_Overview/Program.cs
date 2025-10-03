/*
====================================================
 Introduction to Algorithms
====================================================
• Definition: An algorithm is a finite sequence of well-defined instructions to solve a problem.
• Importance:
   - Provides step-by-step solutions
   - Optimizes performance (time & space)
   - Basis of computer science & problem solving
• Characteristics:
   - Input: Zero or more values
   - Output: At least one result
   - Definiteness: Each step is clear
   - Finiteness: Must terminate
   - Effectiveness: Each operation is basic enough
• Examples in real life: Cooking recipe, Google search ranking, ATM transaction
*/

/*
====================================================
Types of Algorithms
====================================================
1. Brute Force – Tries all possibilities until solution is found.
2. Divide and Conquer – Splits problem into subproblems (e.g., Merge Sort, Quick Sort).
3. Greedy – Chooses the best option at each step (e.g., Huffman Coding).
4. Dynamic Programming – Solves problems by reusing results of subproblems (e.g., Fibonacci, Knapsack).
5. Backtracking – Tries possibilities, discards invalid ones (e.g., N-Queens, Sudoku).
6. Randomized – Uses randomness for decisions (e.g., Randomized Quick Sort).
*/

/*
====================================================
Algorithm Complexity
====================================================
• Time Complexity:
   - Measures how execution time grows with input size.
   - Big-O Notation: O(1), O(log n), O(n), O(n log n), O(n^2), etc.
   - Example: Linear Search O(n), Binary Search O(log n).

• Space Complexity:
   - Memory required by the algorithm.
   - Includes input storage, temporary variables, recursion stack.

• Tradeoff:
   - Sometimes saving time requires more space (and vice versa).
*/

/*
====================================================
 Searching Algorithms
====================================================
1. Linear Search:
   - Check each element one by one.
   - Time: O(n).
   - Simple but slow for large datasets.

2. Binary Search:
   - Works on sorted data.
   - Divide array into halves repeatedly.
   - Time: O(log n).
   - Much faster for large inputs.

3. Hashing:
   - Uses hash function to store/retrieve data quickly.
   - Average: O(1), Worst: O(n).
*/

/*
====================================================
 Sorting Algorithms
====================================================
1. Bubble Sort – Compare and swap adjacent elements (O(n^2)).
2. Selection Sort – Find min and put in correct place (O(n^2)).
3. Insertion Sort – Insert elements into sorted portion (O(n^2)).
4. Merge Sort – Divide and Conquer (O(n log n)).
5. Quick Sort – Partition-based sorting (O(n log n) avg, O(n^2) worst).
6. Heap Sort – Uses heap data structure (O(n log n)).
7. Counting / Radix / Bucket Sort – Non-comparison based, useful for integers.
*/

/*
====================================================
 Graph Algorithms
====================================================
• Representations:
   - Adjacency Matrix
   - Adjacency List

• Algorithms:
   1. BFS (Breadth-First Search) – Level by level traversal.
   2. DFS (Depth-First Search) – Explore as far as possible before backtracking.
   3. Dijkstra’s Algorithm – Shortest path in weighted graphs.
   4. Bellman-Ford Algorithm – Shortest path with negative weights.
   5. Floyd-Warshall – All pairs shortest paths.
   6. Kruskal & Prim – Minimum Spanning Tree.
*/

/*
====================================================
 Dynamic Programming (DP)
====================================================
• Idea: Store results of subproblems to avoid recomputation.
• Steps:
   1. Define the subproblem.
   2. Write recurrence relation.
   3. Store solutions (memoization/tabulation).
• Examples:
   - Fibonacci Sequence
   - Longest Common Subsequence
   - Knapsack Problem
   - Matrix Chain Multiplication
• Complexity: Often reduces exponential problems to polynomial.
*/

/*
====================================================
 Advanced Algorithms
====================================================
• String Matching:
   - Naive Search
   - KMP Algorithm
   - Rabin-Karp
• Computational Geometry:
   - Convex Hull
   - Line Intersection
• Cryptographic Algorithms:
   - RSA, AES, SHA
• Machine Learning Algorithms:
   - Decision Trees, Neural Networks
• Parallel & Distributed Algorithms:
   - MapReduce
   - Multithreaded Sorting
*/

/*
====================================================
 Conclusion
====================================================
• Algorithms = Foundation of computer science.
• Key Takeaways:
   - Choose right algorithm for the problem.
   - Always analyze time and space complexity.
   - Understand trade-offs.
• Career Importance:
   - Crucial for interviews, coding challenges, and software engineering.
• Final Tip:
   - Practice implementing algorithms.
   - Learn when and why to use them, not just how.
*/
