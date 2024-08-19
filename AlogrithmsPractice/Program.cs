using System.Drawing;

int[][] fourXfour = new int[][]
{
    new int[]
    {
        1, 2, 3, 4
    },
    new int[]
    {
        5, 6, 7, 8
    },
    new int[]
    {
        9, 10, 11, 12
    },
    new int[]
    {
        13, 14, 15, 16
    }
};

int[][] threeXthree = new int[][]
{
    new int[]
    {
        1, 2, 3,
    },
    new int[]
    {
        4, 5, 6,
    },
    new int[]
    {
        7, 8, 9,
    }
};

int[][] twoXtwo = new int[][]
{
    new int[]
    {
        1, 2
    },
    new[]
    {
        3, 4
    }
};

int[][] fiveXfive= new int[][]
{
    new int[]
    {
        1, 2, 3, 4, 5
    },
    new int[]
    {
        6, 7, 8, 9, 10
    },
    new int[]
    {
        11, 12, 13, 14, 15
    },
    new int[]
    {
        16, 17, 18, 19, 20
    },
    new int[]
    {
        21, 22, 23, 24, 25
    }
};

string imgPath = @"C:\Users\mohamed.shokry\Downloads\1646145027866.jpg";

var img = new Bitmap(imgPath);

int width = img.Width;

int height = img.Height;

int[][] imgMatrix = new int[width][];

for (int i = 0; i < width; i++)
{
    imgMatrix[i] = new int[height];
}

for (int i = 0; i < width; i++)
{
    for (int j = 0; j < height; j++)
    {
        imgMatrix[i][j] = img.GetPixel(i, j).ToArgb();
    }
}

int[][] rotatedImgMatrix = RotateMatrix(imgMatrix);

Bitmap rotatedImg = new Bitmap(width, height);

for (int i = 0; i < width; i++)
{
    for (int j = 0; j < height; j++)
    {
        rotatedImg.SetPixel(i, j, Color.FromArgb(rotatedImgMatrix[i][j]));
    }
}

rotatedImg.Save(@"C:\Users\mohamed.shokry\Downloads\rotatedImg.jpg");

int[][] RotateMatrix(int[][] matrix)
{
    int n = matrix.Length;

    double max = n - 1;

    int layers = n / 2;
    
    for (int layer = 0; layer < layers; layer++)
    {
        for (int i = layer; i < max - layer; i++)
        {
            int top = matrix[layer][i];
            int right = matrix[i][n - 1 - layer];
            int bottom = matrix[n - 1 - layer][n - 1 - i];
            int left = matrix[n - 1 - i][layer];

            matrix[layer][i] = left;
            matrix[i][n - 1 - layer] = top;
            matrix[n - 1 - layer][n - 1 - i] = right;
            matrix[n - 1 - i][layer] = bottom;
        }
    }

    return matrix;
}