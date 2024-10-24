int[] arr = new int[]
{
    2, 1, 5, 6, 2, 3
};


Solution s = new Solution();

Console.WriteLine(s.LargestRectangleArea(arr));


public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int max = 0;

        Stack<(int index, int height)> stack = new();

        for (int i = 0; i < heights.Length; i++)
        {
            int start = i;

            while (stack.Count > 0 && stack.Peek().height > heights[i])
            {
                (int index, int height) = stack.Pop();
                max = Math.Max(max, height * (i - index));
                start = index;
            }

            stack.Push((start, heights[i]));
        }

        while (stack.Count>0)
        {
            (int index,int height) = stack.Pop();
            max = Math.Max(max, height * (heights.Length - index));
        }
        
        return max;
    }
}