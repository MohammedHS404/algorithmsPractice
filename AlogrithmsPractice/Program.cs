Solution sol = new Solution();

int[] nums = new int[]
{
    9,6,8,8,5,6,3
};

int result = sol.Trap(nums);

Console.WriteLine(result);


public class Solution
{
    public int Trap(int[] height)
    {
        int l = 0;

        while (l < height.Length && height[l] == 0)
        {
            l++;
        }

        if (l == height.Length)
        {
            return 0;
        }

        int r = l + 1;

        int totalWater = 0;

        while (r < height.Length)
        {
            List<int> heightsOfMiddleBlocks = new();

            int emptySpacesInBetween = 0;

            while (r < height.Length)
            {
                if (height[r] == 0)
                {
                    r++;
                    continue;
                }

                int distance = r - l - 1;

                if (distance == 0)
                {
                    if(height[r] >= height[l])
                    {
                        l = r;
                        heightsOfMiddleBlocks.Clear();
                        emptySpacesInBetween = 0;
                    }
                    else
                    {
                        heightsOfMiddleBlocks.Add(height[r]);
                    }
                    
                    r++;
                    continue;
                }

                int minHeight = Math.Min(height[l], height[r]);

                int totalSpace = minHeight * distance;

                int occupiedSpace = 0;

                foreach (int h in heightsOfMiddleBlocks)
                {
                    if (h < minHeight)
                    {
                        occupiedSpace += h;
                    }
                    else
                    {
                        occupiedSpace += minHeight;
                    }
                }

                int emptySpace = totalSpace - occupiedSpace - emptySpacesInBetween;

                if (emptySpace <= 0)
                {
                    heightsOfMiddleBlocks.Add(height[r]);
                    r++;
                    continue;
                }

                heightsOfMiddleBlocks.Add(height[r]);
                emptySpacesInBetween += emptySpace;
                totalWater += emptySpace;

                if (height[r] >= height[l])
                {
                    l = r;
                    heightsOfMiddleBlocks.Clear();
                    emptySpacesInBetween = 0;
                }

                r++;
            }
        }

        return totalWater;
    }
}