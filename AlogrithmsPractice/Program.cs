char[][] input = new char[][]
{
    new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' }, 
    new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
    new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
    new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
    new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
    new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
    new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
    new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
    new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
};

Solution solution = new Solution();

bool result = solution.IsValidSudoku(input);

Console.WriteLine(result);

public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<int,HashSet<char>> columnSet = new Dictionary<int, HashSet<char>>();
        
        for (int rowIndex = 0; rowIndex < board.Length; rowIndex++)
        {
            HashSet<char> rowSet = new HashSet<char>();
            
            for (int columnIndex = 0; columnIndex < board[rowIndex].Length; columnIndex++)
            {
                if(rowSet.Contains(board[rowIndex][columnIndex]))
                {
                    return false;
                }
                
                if (board[rowIndex][columnIndex] != '.')
                {
                    rowSet.Add(board[rowIndex][columnIndex]);
                }
                
                if(columnSet.ContainsKey(columnIndex))
                {
                    if (columnSet[columnIndex].Contains(board[rowIndex][columnIndex]))
                    {
                        return false;
                    }
                    if (board[rowIndex][columnIndex] != '.')
                    {
                        columnSet[columnIndex].Add(board[rowIndex][columnIndex]);
                    }
                }
                else
                {
                    columnSet.Add(columnIndex, new HashSet<char>());
                    
                    if (board[rowIndex][columnIndex] != '.')
                    {
                        columnSet[columnIndex].Add(board[rowIndex][columnIndex]);
                    }
                }
            }
            Console.WriteLine();
        }
        
        for (int rowIndex = 0; rowIndex < board.Length; rowIndex+=3)
        {
            for (int columnIndex = 0; columnIndex < board[rowIndex].Length; columnIndex+=3)
            {
                HashSet<char> squareSet = new HashSet<char>();
                
                for(int i=rowIndex; i<rowIndex+3; i++)
                {
                    for(int j=columnIndex; j<columnIndex+3; j++)
                    {
                        if(squareSet.Contains(board[i][j]))
                        {
                            return false;
                        }

                        if (board[i][j] != '.')
                        {
                            squareSet.Add(board[i][j]);
                        }
                    }
                }
            }
        }
        
        return true;
    }
}