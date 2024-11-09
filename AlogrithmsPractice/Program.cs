
Solution sol = new Solution();

int[] prices = [2, 1, 3, 4];

int result = sol.MaxProfit(prices);

Console.WriteLine(result);

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0)
        {
            return 0;
        }

        if (prices.Length == 1)
        {
            return 0;
        }

        int max = 0;
        int leftIndex = 0;
        int rightIndex = 1;

        while (rightIndex < prices.Length)
        {
            if (prices[rightIndex] > prices[leftIndex])
            {
                max = Math.Max(max, prices[rightIndex] - prices[leftIndex]);
            }
            else
            {
                leftIndex = rightIndex;
            }

            rightIndex++;
        }

        return max;
    }
}