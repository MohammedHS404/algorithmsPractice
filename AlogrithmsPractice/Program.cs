public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();

        if (nums.Length < 3)
        {
            return result;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        List<int> temp = new List<int>();
                        temp.Add(nums[i]);
                        temp.Add(nums[j]);
                        temp.Add(nums[k]);
                        temp.Sort();
                        if (!result.Any(l=>l.SequenceEqual(temp)))
                        {
                            result.Add(temp);
                        }
                    }
                }
            }
        }

        return result;
    }
}