int[][] matrix =
{
    new[]
    {
        1, 2, 3, 4
    },
    new[]
    {
        5, 6, 7, 8
    },
    new[]
    {
        9, 10, 11, 12
    },
    new[]g
    {
        13, 0, 15, 0
    }
};

ZeroMatrix(matrix);

foreach (var row in matrix)
{
    Console.WriteLine(string.Join(", ", row));
}

static void ZeroMatrix(int[][] matrix)
{
    HashSet<int> rowsToSkip = new HashSet<int>();
    HashSet<int> columnsToSkip = new HashSet<int>();

    for (int r = 0; r < matrix.Length; r++)
    {
        for (int c = 0; c < matrix[r].Length; c++)
        {
            if (matrix[r][c] == 0)
            {
                rowsToSkip.Add(r);
                columnsToSkip.Add(c);
            }
        }
    }

    foreach (var row in rowsToSkip)
    {
        for (int i = 0; i < matrix[row].Length; i++)
        {
            matrix[row][i] = 0;
        }
    }

    foreach (var column in columnsToSkip)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            int[] t = matrix[i];
            t[column] = 0;
        }
    }
}