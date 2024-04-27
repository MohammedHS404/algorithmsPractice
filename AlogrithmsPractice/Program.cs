string test = "cabababababababd";

Console.WriteLine(LongestPalindrome(test));

string LongestPalindrome(string s)
{
    if (s.Length == 0)
    {
        return "";
    }

    string longest = "";

    for (int i = 0; i < s.Length; i++)
    {
        for (int j = i + 1; j <= s.Length; j++)
        {
            string sub = s.Substring(i, j - i);
            
            if (IsPalindromic(sub) && sub.Length > longest.Length)
            {
                longest = sub;
            }
        }
    }
    
    return longest;
}

bool IsPalindromic(string s)
{

    int l = 0;
    int r = s.Length - 1;

    while (l < r)
    {
        if (s[l] != s[r])
        {
            return false;
        }
        l++;
        r--;
    }

    return true;
}