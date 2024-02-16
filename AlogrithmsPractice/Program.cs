class Solution
{
    public int MaxProduct(int[] nums)
    {
        int res = nums.Max();
        
        int curMin = 1, curMax = 1;

        foreach (int n in nums)
        {
            int tmp = curMax;
            
            curMax = Math.Max(n * curMax, Math.Max(n * curMin, n));
            
            curMin = Math.Min(tmp * n, Math.Min(curMin * n, n));

            res = Math.Max(res, curMax);
        }

        return res;
    }
}