Solution solution = new();
Console.WriteLine(solution.MaxSubArray(new int[] { -1, 0 }));

class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int currentSum = 0;
        int maxSubArray = int.MinValue;
        foreach (int num in nums)
        {
            // If it was all positive then we would only sum them up
            // But since there are negatives we would need to start the array and end it somewhere
            // Start: If we had a negative sum before a positive number, then we can be sure that ditching
            //  the negative sum and starting from that positive number would ensure a higher sum, so we 
            //  check if after adding the value we would get a higher value than the current number
            //  for example -2,1,-3,4; -2,1,-3 would accumulate -4 which is less than 4, so restarting
            //  the sum from 4 would be better. 
            // End: If we had a negative number after a positive number we should continue only if 
            //  a large enough positive number would exist after the negative number to compensate for
            //  the loss. 
            //  for example 2,1,-5,4; 2,1 would accumulate 3, after adding -5, -2 would remain, so 
            //  currentSum will be -2 and maxSubArray will be 3. When we get to 4, we can be sure that it's
            //  better than -2 so it's better to use it as the current sum and since the currentSum will be 4
            //  4>3 then the maxSubArray will be also 4
            currentSum = Math.Max(num, num + currentSum);
            maxSubArray = Math.Max(currentSum, maxSubArray);
        }

        return maxSubArray;
    }
}