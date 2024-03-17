Solution sol = new Solution();

int[] nums = new int[]
{
    -1,0,1,2,-1,-4
};

IList<IList<int>> result = sol.ThreeSum(nums);

foreach (var item in result)
{
    Console.WriteLine(string.Join(", ", item));
}

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] numbers)
    {
        Array.Sort(numbers);

        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < numbers.Length - 2; i++)
        {
            if (i > 0 && numbers[i] == numbers[i - 1])
            {
                continue;
            }   

            int left = i + 1; 
            int right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[i] + numbers[left] + numbers[right] == 0)
                {
                    result.Add(new int[]
                    {
                        numbers[i], numbers[left], numbers[right]
                    });
                    
                    left++;
                    while (left < right && numbers[left] == numbers[left + 1])
                    {
                        left++;
                    }
                }
                else if (numbers[i] + numbers[left] + numbers[right] > 0)
                {
                    right--;
                }
                else if (numbers[i] + numbers[left] + numbers[right] < 0)
                {
                    left++;
                }
            }
        }

        return result;
    }
}