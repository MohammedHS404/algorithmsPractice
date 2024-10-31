public class Solution
{
    public int Search(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;

        return BinarySearch(nums, start, end, target);
    }

    private int BinarySearch(int[] arr, int start, int end, int target)
    {
        if (start > end)
        {
            return -1;
        }

        if (arr[start] == target)
        {
            return start;
        }

        if (arr[end] == target)
        {
            return end;
        }

        if (start == end)
        {
            return -1;
        }

        int mid = start + (end - start) / 2;

        if (arr[mid] == target)
        {
            return mid;
        }
        if (arr[mid] > target)
        {
            return BinarySearch(arr, start, mid - 1, target);
        }
        else
        {
            return BinarySearch(arr, mid + 1, end, target);
        }
    }
}
