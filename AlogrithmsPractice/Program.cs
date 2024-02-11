// See https://aka.ms/new-console-template for more information

int[] prices = new int[] { 2,1,2,1,0,1,2 };
Solution sol = new Solution();
Console.WriteLine(sol.MaxProfit(prices));

public class Solution
{
    public int MaxProfit(int[] prices)
    {
            if (prices.Length == 0)
            {
                return 0;
            }

            int leftIndex = 0;

            int rightIndex = 1;
            
            int maxProfit = 0;

            while (rightIndex < prices.Length)
            {
                int left = prices[leftIndex];

                int right = prices[rightIndex];

                if (right < left)
                {
                    leftIndex = rightIndex;
                    rightIndex++;
                }
                else
                {
                    int profit = right - left;
                    maxProfit = Math.Max(maxProfit, profit);
                    rightIndex++;
                }
            }

            return maxProfit;
    }
}