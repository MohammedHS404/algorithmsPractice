Solution sol = new Solution();
Console.WriteLine(sol.IsPalindrome("A man, a plan, a canal: Panama"));

public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrWhiteSpace(s))
        {
            return true;
        }
        
        for (int i = 0, j = s.Length - 1; i < j; i++, j--)
        {
            while(!char.IsLetterOrDigit(s[i]) && i < j)
            {
                i++;
            }
            
            while(!char.IsLetterOrDigit(s[j]) && i < j)
            {
                j--;
            }
   
            if (char.ToLower(s[i]) != char.ToLower(s[j]))
            {
                return false;
            }
        }
        
        return true;
    }
}