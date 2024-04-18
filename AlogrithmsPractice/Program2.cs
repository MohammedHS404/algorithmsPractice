// Solution sol = new Solution();
//
// int[] nums = new int[]
// {
//     2,1,0,1,2
// };
//
// int result = sol.Trap(nums);
//
// Console.WriteLine(result);
//
// public class Solution
// {
//     public int Trap(int[] height)
//     {
//         int l = 0;
//
//         int r = 1;
//
//         int totalWater = 0;
//
//         while (r < height.Length)
//         {
//             int distance = 0;
//
//             int heightsOfMiddleBlocks = 0;
//
//             while (r < height.Length)
//             {
//                 if (height[r] == 0)
//                 {
//                     distance++;
//                     r++;
//                     continue;
//                 }
//
//                 if (distance == 0)
//                 {
//                     heightsOfMiddleBlocks += height[r];
//                     distance++;
//                     r++;
//                     continue;
//                 }
//
//                 int minHeight = Math.Min(height[l], height[r]);
//
//                 int totalSpace = minHeight * distance;
//
//                 int occupiedSpace = heightsOfMiddleBlocks;
//
//                 int emptySpace = totalSpace - occupiedSpace;
//
//                 if (emptySpace <= 0)
//                 {
//                     heightsOfMiddleBlocks += height[r];
//                     distance++;
//                     r++;
//                     continue;
//                 }
//
//                 totalWater += emptySpace;
//
//                 distance = 0;
//
//                 heightsOfMiddleBlocks = 0;
//
//                 l = r;
//                 r++;
//             }
//         }
//
//         return totalWater;
//     }
// }