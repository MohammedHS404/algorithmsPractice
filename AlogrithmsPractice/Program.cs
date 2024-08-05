Solution solution = new Solution();

int[] temperatures = new int[]
{
    75, 71, 69, 72, 76
};

int[] result = solution.DailyTemperatures(temperatures);

foreach (int item in result)
{
    Console.WriteLine(item);
}

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                int index = stack.Pop();
                result[index] = i - index;
            }

            stack.Push(i);
        }

        return result;
    }
}