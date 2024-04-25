Solution sol = new Solution();

int[] nums = new int[]
{
    4, 0, 3, 0, 2
};

int result = sol.Trap(nums);

Console.WriteLine(result);


public class Solution
{
    public int Trap(int[] height)
    {
        int l = 0;

        int r = height.Length - 1;

        int leftMax = height[l];
        
        int rightMax = height[r];
        
        int totalWater = 0;

        while (l<r)
        {
            if (leftMax < rightMax)
            {
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                totalWater += leftMax - height[l];
            }
            else
            {
                r--;
                rightMax = Math.Max(rightMax, height[r]);
                totalWater += rightMax - height[r];
            }
        }

        return totalWater;
    }
}