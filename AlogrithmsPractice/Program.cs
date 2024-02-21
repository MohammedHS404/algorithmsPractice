using Newtonsoft.Json;

string jsonString = "[[\".\",\"4\",\".\",\".\",\".\",\".\",\".\",\".\",\".\"],[\".\",\".\",\"4\",\".\",\".\",\".\",\".\",\".\",\".\"],[\".\",\".\",\".\",\"1\",\".\",\".\",\"7\",\".\",\".\"],[\".\",\".\",\".\",\".\",\".\",\".\",\".\",\".\",\".\"],[\".\",\".\",\".\",\"3\",\".\",\".\",\".\",\"6\",\".\"],[\".\",\".\",\".\",\".\",\".\",\"6\",\".\",\"9\",\".\"],[\".\",\".\",\".\",\".\",\"1\",\".\",\".\",\".\",\".\"],[\".\",\".\",\".\",\".\",\".\",\".\",\"2\",\".\",\".\"],[\".\",\".\",\".\",\"8\",\".\",\".\",\".\",\".\",\".\"]]";
char[][] input = JsonConvert.DeserializeObject<char[][]>(jsonString);
Solution solution = new Solution();

bool result = solution.IsValidSudoku(input);

Console.WriteLine(result);

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<int, HashSet<char>> columnSet = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> rowSet = new Dictionary<int, HashSet<char>>();
        Dictionary<string, HashSet<char>> subGridSet = new Dictionary<string, HashSet<char>>();

        for (int i = 0; i < board.Length; i++)
        {
            rowSet.Add(i, new HashSet<char>());
            columnSet.Add(i, new HashSet<char>());
        }

        for (int rowIndex = 0; rowIndex < board.Length; rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < board[rowIndex].Length; columnIndex++)
            {
                char currentChar = board[rowIndex][columnIndex];

                if (currentChar == '.')
                {
                    continue;
                }

                if (rowSet[rowIndex].Contains(currentChar) || columnSet[columnIndex].Contains(currentChar))
                {
                    return false;
                }

                rowSet[rowIndex].Add(currentChar);

                columnSet[columnIndex].Add(currentChar);

                string key = Math.Floor(rowIndex/3f) + "," + Math.Floor(columnIndex/3f);

                if (!subGridSet.TryAdd(key, new HashSet<char>()))
                {
                    if (subGridSet[key].Contains(currentChar))
                    {
                        return false;
                    }

                    subGridSet[key].Add(currentChar);
                }
            }
        }

        return true;
    }
}