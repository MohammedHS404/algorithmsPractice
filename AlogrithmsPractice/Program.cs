Solution solution = new Solution();
int[] nums = new int[] { 2, 7, 11, 15 };
int target = 11;
int[] result = solution.TwoSum(nums, target);

foreach (var item in result)
{
    Console.WriteLine(item);
}
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> numsSet = new Dictionary<int,int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numsSet.TryGetValue(complement, out int value))
            {
                return new int[] { value, i };
            }
            numsSet.Add(nums[i],i);
        }
        
        return new int[] { } ;
    }
}