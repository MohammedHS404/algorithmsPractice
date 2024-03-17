public class Solution
{
    public int MaxArea(int[] height)
    {

        int l = 0;
        int r = height.Length - 1;

        int maxArea = 0;

        while (l < r)
        {
            int xDiff = Math.Abs(r - l);

            int area = Math.Min(height[l], height[r]) * xDiff;

            maxArea = Math.Max(maxArea, area);

            if (height[l] < height[r])
            {
                l++;
            }
            else
            {
                r--;
            }
        }

        return maxArea;
    }
}