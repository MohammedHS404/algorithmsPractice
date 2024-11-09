
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
        int min = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else
            {
                max = Math.Max(max, prices[i] - min);
            }
        }
        
        return max;
    }
}