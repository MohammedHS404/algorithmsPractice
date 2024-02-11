// Solution solution = new();
//
// int[] a = {};
// int[] b = { };
//
// Console.WriteLine(solution.solution(a, b));
//
// class Solution
// {
//     public int solution(int[] A, int[] B)
//     {
//         int fairs = 0;
//
//         for (int i = 1; i < A.Length; i++)
//         {
//             int prevSubArrayLength = i;
//
//             int sumAPrevK = 0;
//
//             int sumBPrevK = 0;
//
//             for (int j = 0; j < prevSubArrayLength; j++)
//             {
//                 sumAPrevK += A[j];
//                 sumBPrevK += B[j];
//             }
//
//             int sumAAfterK = 0;
//             int sumBAfterK = 0;
//
//             for (int j = prevSubArrayLength; j < A.Length; j++)
//             {
//                 sumAAfterK += A[j];
//                 sumBAfterK += B[j];
//             }
//
//             bool prevEqual = sumAPrevK == sumBPrevK;
//
//             bool afterEqual = sumAAfterK == sumBAfterK;
//             
//             bool equal = sumAPrevK == sumAAfterK && sumBPrevK == sumBAfterK;
//
//             if (prevEqual && afterEqual && equal)
//             {
//                 fairs++;
//             }
//         }
//
//         return fairs;
//     }
// }