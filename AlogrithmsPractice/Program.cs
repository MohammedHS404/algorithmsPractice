Solution solution = new Solution();
Console.WriteLine(solution.RomanToInt("VI"));

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> roman = new Dictionary<char, int>()
        {
            {
                'I', 1
            },
            {
                'V', 5
            },
            {
                'X', 10
            },
            {
                'L', 50
            },
            {
                'C', 100
            },
            {
                'D', 500
            },
            {
                'M', 1000
            }
        };

        int result = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int number = roman[s[i]];

            if (i < s.Length - 1)
            {
                int nextNumber = roman[s[i + 1]];

                if (number < nextNumber)
                {
                    result -= number;
                    continue;
                }
            }

            result += number;
        }

        return result;
    }
}