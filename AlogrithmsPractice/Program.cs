int[] arr = new int[]
{
    1, 2, 3, 4, 5
};


Solution s = new Solution();

Console.WriteLine(s.LargestRectangleArea(arr));


public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int max = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = i; j >= 0; j--)
            {
                int height = heights[j];

                int sum = 0;
                
                for (int k = i - 1; k >= 0; k--)
                {
                    if (heights[k] >= height)
                    {
                        sum += height;
                    }
                    else
                    {
                        break;
                    }
                }


                if (sum > max)
                {
                    max = sum;
                }
            }
        }
        return max;
    }
}