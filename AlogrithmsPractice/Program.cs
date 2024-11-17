
Solution solution = new Solution();

Console.WriteLine(solution.LengthOfLongestSubstring("bbbbadsbd")); // 3

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {

        HashSet<char> set = new HashSet<char>();

        int max = 0;

        int l = 0, r = 0;

        while (r < s.Length)
        {
            if (set.Contains(s[r]))
            {
                max = Math.Max(max, r - l);
                set.Remove(s[l]);
                l++;
            }
            else
            {
                set.Add(s[r]);
                r++;
            }
        }

        return Math.Max(max, r - l);
    }
}