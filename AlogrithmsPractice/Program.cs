Solution solution = new Solution();

Console.WriteLine(solution.LongestRepeatingCharacter("ABAB"));
Console.WriteLine(solution.LongestRepeatingCharacter("AABABBA"));
Console.WriteLine(solution.LongestRepeatingCharacter("ABABABABA"));
Console.WriteLine(solution.LongestRepeatingCharacter("ABCD"));
Console.WriteLine(solution.LongestRepeatingCharacter("AAAA"));
Console.WriteLine(solution.LongestRepeatingCharacter("AAABBB"));
Console.WriteLine(solution.LongestRepeatingCharacter("AAABBBAA"));

public class Solution {
    public int LongestRepeatingCharacter(string s) {
        int left = 0, right = 0, max = 0;

        char current = s[0];

        while (right < s.Length) {
            if (s[right] == current) {
                right++;
                max = Math.Max(max, right - left);
            } else {
                left = right;
                current = s[right];
            }
        }

        return max;
    }
}