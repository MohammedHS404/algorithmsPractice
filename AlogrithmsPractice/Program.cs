Solution solution = new();

int[] numbers =
{
    3, 24, 50, 79, 88, 150, 345
};

int target = 200;

int[] result = solution.TwoSum(numbers, target);

foreach (var number in result)
{
    Console.WriteLine(number);
}

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
            {
                return new int[]
                {
                    left + 1, right + 1
                };
            }
            else if (numbers[left] + numbers[right] > target)
            {
                right--;
            }
            else if (numbers[left] + numbers[right] < target)
            {
                left++;
            }
        }

        return new int[2];
    }
}