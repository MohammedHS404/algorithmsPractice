string test = "a";

Solution solution = new Solution();

Console.WriteLine(solution.LongestPalindrome(test));

class Solution
{
 

    public string LongestPalindrome(string s)
    {
        if (s.Length == 0)
        {
            return "";
        }

        string longest = "";

        for (int i = 0; i < s.Length; i++)
        {
            string odd = PalindromicLength(s, i, i);
            string even = PalindromicLength(s, i, i + 1);

            if (odd.Length > longest.Length)
            {
                longest = odd;
            }

            if (even.Length > longest.Length)
            {
                longest = even;
            }
        }

        return longest;
    }

    string PalindromicLength(string s, int l, int r)
    {
        if (l > r)
        {
            return "";
        }

        if (l < 0 || r >= s.Length)
        {
            return "";
        }
    
        string result = "";

        while (l >= 0 && r < s.Length)
        {
            if (s[l] == s[r])
            {
                result = s.Substring(l, r - l + 1);
            }
            else
            {
                break;
            }
        
            l--;
            r++;
        }

        return result;
    }   
}