int[] array = { 100, 4, 200, 1, 3, 2 };

Solution sol = new Solution();

Console.WriteLine(sol.LongestConsecutive(array));

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        int longestStreak = 0;

        HashSet<int> numSet = new HashSet<int>();

        foreach (int num in nums)
            numSet.Add(num);

        foreach (int num in numSet)
        {
            int longest = 0;

            if (numSet.Contains(num - 1))
            {
                longest = 0;
            }

            int nextNum = num;
            
            while (numSet.Contains(nextNum))
            {
                longest++;
                nextNum++;
            }
            
            longestStreak = Math.Max(longestStreak, longest);
        }
        
        return longestStreak;
    }
}