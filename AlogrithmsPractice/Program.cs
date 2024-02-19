public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> numsCount = new Dictionary<int, int>();
        
        foreach (int num in nums)
        {
            if (!numsCount.TryAdd(num,1))
            {
                numsCount[num]++;
            }
        }

        return numsCount.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }
}