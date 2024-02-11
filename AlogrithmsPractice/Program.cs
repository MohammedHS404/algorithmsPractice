public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums.Length);
        foreach (int num in nums)
        {
            if (!set.Add(num))
            {
                return true;
            }
        }

        return false;
    }
}