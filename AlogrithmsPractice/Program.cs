Solution solution = new Solution();
int[] nums = new int[] { 1};
int k = 2;
int[] result = solution.TopKFrequent(nums, k);
Console.WriteLine(string.Join(", ", result));

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, List<int>> freq = new Dictionary<int, List<int>>();
        Dictionary<int, int> numsCount = new Dictionary<int, int>();
        
        for(int i=0; i<nums.Length; i++)
        {
            freq.Add(i, new List<int>());
        }

        foreach (int num in nums)
        {
            if (!numsCount.TryAdd(num, 1))
            {
                numsCount[num]++;
            }
        }
        
        foreach (var item in numsCount)
        {
            if (!freq.ContainsKey(item.Value))
            {
                freq.Add(item.Value, new List<int>());
            }
            
            freq[item.Value].Add(item.Key);
        }
        
        List<int> result = new List<int>();
        
        for(int i=nums.Length; i>=0; i--)
        {
            if(freq.TryGetValue(i, out var value))
            {
                result.AddRange(value);
            }
            
            if(result.Count == k)
            {
                break;
            }
        }
        
        return result.ToArray();
    }
}