public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        foreach (char c in s)
        {
            if (t.Contains(c))
            {
                t = t.Remove(t.IndexOf(c), 1);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}