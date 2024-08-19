int[][] matrix =
{
    new[]
    {
        0, 2, 3, 4
    },
    new[]
    {
        5, 6, 7, 8
    },
    new[]
    {
        9, 10, 11, 12
    },
    new[]
    {
        13, 14, 15, 0
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
        if (rowsToSkip.Contains(r))
        {
            continue;
        }

        for (int c = 0; c < matrix[r].Length; c++)
        {
            if (columnsToSkip.Contains(c) || rowsToSkip.Contains(r))
            {
                continue;
            }

            if (matrix[r][c] == 0)
            {

                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][c] = 0;
                }

                for (int i = 0; i < matrix[r].Length; i++)
                {
                    matrix[r][i] = 0;
                }

                rowsToSkip.Add(r);
                columnsToSkip.Add(c);
            }
        }
    }
}