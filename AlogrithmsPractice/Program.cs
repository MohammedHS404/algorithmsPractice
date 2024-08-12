
int[][] matrix = new int[][]
{
    new int[] {1, 2, 3},
    new int[] {4, 5, 6},
    new int[] {7, 8, 9}
};

int[][] r = RotateMatrix(matrix);

foreach (var row in r)
{
    Console.WriteLine(string.Join(", ", row));
}


int[][] RotateMatrix(int[][] matrix)
{
    int[][] result = new int[matrix.Length][];
    
    for (int i = 0; i < matrix.Length; i++)
    {
        result[i] = new int[matrix.Length];
    }
    
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix.Length; j++)
        {
            result[j][matrix.Length - 1 - i] = matrix[i][j];
        }
    }
    
    return result;
}