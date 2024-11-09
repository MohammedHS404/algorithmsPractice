
Solution sol = new Solution();

int[] prices = [2, 1, 3, 4];

int result = sol.MaxProfit(prices);

Console.WriteLine(result);

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int max = 0;

        for (int i = prices.Length - 1; i > 0; i--)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                int profit = prices[i] - prices[j];
                if (profit > max)
                {
                    max = profit;
                }
            }
        }

        return max;
    }
}