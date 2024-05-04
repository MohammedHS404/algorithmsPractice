Solution solution = new Solution();

IList<string> result = solution.GenerateParenthesis(3);

foreach (var item in result)
{
    Console.WriteLine(item);
}

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> result = new List<string>();
        dfs(n, 0, "", result);
        return result;
    }

    //dfs

    public void dfs(int n, int total, string current, List<string> result)
    {
        if (current.Length / 2 == n)
        {
            result.Add(current);
            return;
        }

        if (total < n)
        {
            dfs(n, total + 1, current + "(", result);
        }

        if (total * 2 > current.Length)
        {
            dfs(n, total, current + ")", result);
        }
    }
}