public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] countOfEachLetter = new int[26];
        
        for (int i = 0; i < s.Length; i++)
        {
            countOfEachLetter[s[i] - 'a']++;
            countOfEachLetter[t[i] - 'a']--;
        }
        
        foreach (var count in countOfEachLetter)
        {
            if (count != 0)
            {
                return false;
            }
        }

        return true;
    }
}