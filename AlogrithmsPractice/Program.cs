Solution solution = new Solution();

// [[1,3,5,7],[10,11,16,20],[23,30,34,60]]

int[][] matrix = new int[3][];

matrix[0] = new int[] { 1, 3, 5, 7 };
matrix[1] = new int[] { 10, 11, 16, 20 };
matrix[2] = new int[] { 23, 30, 34, 60 };

int target = 31;

bool result = solution.SearchMatrix(matrix, target);

Console.WriteLine(result);


public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int arrayIndex = -1;

        for (int i = 0; i < matrix.Length; i++)
        {
            if (matrix[i][0] <= target && matrix[i][matrix[i].Length - 1] >= target)
            {
                arrayIndex = i;
                break;
            }
        }

        if (arrayIndex == -1)
        {
            return false;
        }

        int[] nums = matrix[arrayIndex];
        int start = 0;
        int end = nums.Length - 1;

        return BinarySearch(nums, start, end, target) > -1;
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
