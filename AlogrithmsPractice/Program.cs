var arr = new int[] { 2, 1, 5, 6, 2, 3 };
int max = 0;
var toConsider = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    if (!toConsider.Contains(arr[i]))
    {
        toConsider[i] = arr[i];
    }

    for (int j = 0; j < toConsider.Length; j++)
    {
        if (toConsider[j] == -1)
        {
            continue;
        }

        if (toConsider[j] <= arr[i])
        {
            var newMax = toConsider[j] * (i + 1);
            if (newMax > max)
            {
                max = newMax;
            }
        }
        else
        {
            toConsider[j] = -1;
        }
    }
}

Console.WriteLine(max);