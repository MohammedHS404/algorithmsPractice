var solution = new Solution();

// var nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

var target = 6;

var result = solution.Search(nums, target);

Console.WriteLine(result);

public class Solution
{
    public int Search(int[] nums, int target)
    {
        var l = 0;

        var r = nums.Length - 1;

        while (l <= r)
        {
            int mid = ((r - l) / 2) + l;

            Console.WriteLine($"l: {l}, r: {r}, mid: {mid}");

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[l] == target)
            {
                return l;
            }

            if (nums[r] == target)
            {
                return r;
            }

            if (nums[mid] >= nums[l])
            {
                if (target >= nums[l] && target <= nums[mid])
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }

                continue;
            }


            if (nums[r] >= nums[mid])
            {
                if (target >= nums[mid] && target <= nums[r])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }

                continue;
            }
        }

        return -1;

    }
}