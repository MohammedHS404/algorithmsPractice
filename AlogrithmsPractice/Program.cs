Console.WriteLine(new Solution().FindMin(new int[] { 1 }));

public class Solution
{
    public int FindMin(int[] nums)
    {
        return FindMin(nums, 0, nums.Length - 1);
    }

    int FindMin(int[] nums, int left, int right)
    {
        if (left == right)
        {
            return nums[left];
        }

        int mid = left + (right - left) / 2;

        if (nums[mid] > nums[right])
        {
            return FindMin(nums, mid + 1, right);
        }
        else
        {
            return FindMin(nums, left, mid);
        }
    }
}