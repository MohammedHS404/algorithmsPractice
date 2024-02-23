// using System;
//
// // you can also use other imports, for example:
// // using System.Collections.Generic;
//
// // you can write to stdout for debugging purposes, e.g.
// // Console.WriteLine("this is a debug message");
//
// Solution solution = new();
//
// Tree t = new (9,new(3,new(3,null,null),null),null);
//
// Console.WriteLine(solution.solution(t));
//
// class Tree
// {
//     public int x;
//     public Tree? l;
//     public Tree? r;
//
//     public Tree(int x, Tree l, Tree r)
//     {
//         this.x = x;
//         this.l = l;
//         this.r = r;
//     }
// };
//
// class Solution
// {
//     public int solution(Tree T)
//     {
//         if(T == null)
//         {
//             return 0;
//         }
//         
//         HashSet<string> threeDigitNumbers = new HashSet<string>();
//         
//         solutionRec(T, "", threeDigitNumbers);
//         
//         return threeDigitNumbers.Count;
//     }
//
//     void solutionRec(Tree T, string previous, HashSet<string> threeDigitNumbers)
//     {
//         string current = previous + T.x;
//         
//         if (previous.Length >= 2)
//         {
//             threeDigitNumbers.Add(current.Substring(previous.Length - 2, 3));
//         }
//
//         if (T.l == null && T.r == null)
//         {
//             return;
//         }
//
//         if (T.l != null)
//         {
//             solutionRec(T.l, current, threeDigitNumbers);
//         }
//
//         if (T.r != null)
//         {
//             solutionRec(T.r, current, threeDigitNumbers);
//         }
//     }
// }