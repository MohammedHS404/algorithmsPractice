Solution solution = new Solution();

Console.WriteLine(solution.IsValid("){")); // True

public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        Dictionary<char, string> types = new Dictionary<char, string>
        {
            {
                '(', "open"
            },
            {
                '[', "open"
            },
            {
                '{', "open"
            },
            {
                ')', "close"
            },
            {
                ']', "close"
            },
            {
                '}', "close"
            }
        };

        Dictionary<char, char> pairs = new Dictionary<char, char>
        {
            {
                '(', ')'
            },
            {
                '[', ']'
            },
            {
                '{', '}'
            }
        };

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]=='(' || s[i]=='[' || s[i]=='{')
            {
                stack.Push(s[i]);
            }
            else if (stack.Count == 0 || pairs[stack.Pop()] != s[i])
            {
                return false;
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }

        return false;
    }
}