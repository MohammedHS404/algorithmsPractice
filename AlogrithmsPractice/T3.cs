// 2using System;
//
// // you can also use other imports, for example:
// // using System.Collections.Generic;
//
// // you can write to stdout for debugging purposes, e.g.
// // Console.WriteLine("this is a debug message");
// Solution solution = new();
// Console.WriteLine(solution.solution(new int[] {3,4,6}, new int[] {6,5,4}));
//
// class Solution
// {
//     public int solution(int[] A, int[] B)
//     {
//         int minSum = 0;
//         
//         Dictionary<int,int> elementToSum = new();
//         
//         for (int max = A.Length; max >0; max--)
//         {
//             int sum = 0;
//             
//             int maxElement=Int32.MinValue;
//             
//             for (int i = 0; i < max; i++)
//             {
//                 sum += A[i];
//                 if (A[i] > maxElement)
//                 {
//                     maxElement = A[i];
//                 }
//             }
//             
//             for (int i = max-1; i < B.Length; i++)
//             {
//                 sum+= B[i];
//                 
//                 if (B[i] > maxElement)
//                 {
//                     maxElement = B[i];
//                 }
//             }
//             
//             if (minSum == 0 || sum < minSum)
//             {
//                 minSum = sum;
//                 elementToSum[sum] = maxElement;
//             }
//         }
//         
//         return elementToSum[minSum];
//     }
// }