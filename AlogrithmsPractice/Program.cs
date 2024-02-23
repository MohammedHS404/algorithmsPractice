using System.Collections.Generic;

int[] a = { 3, 4, 6 };
int[] b = { 6, 5, 4 };

Solution solution = new();

Console.WriteLine(solution.solution(a, b));

class Solution
{
    public int solution(int[] A, int[] B)
    {
        int minSum = 0;

        Dictionary<int, int> elementToSum = new Dictionary<int, int>();

        Dictionary<int, int> sumAMemory = new Dictionary<int, int>();
        Dictionary<int, int> sumBMemory = new Dictionary<int, int>();

        for (int max = A.Length; max > 0; max--)
        {
            int sum = 0;

            int maxElement = int.MinValue;

            if (sumAMemory.ContainsKey(max - 1))
            {
                sum += sumAMemory[max - 1];
            }
            else
            {
                for (int i = 0; i < max; i++)
                {
                    sum += A[i];
                    if (A[i] > maxElement)
                    {
                        maxElement = A[i];
                    }

                    sumAMemory[i] = sum;
                }
            }

            if (sumBMemory.ContainsKey(max - 1))
            {
                sum += sumBMemory[max - 1];
            }
            else
            {
                for (int i = max - 1; i < B.Length; i++)
                {
                    sum += B[i];

                    if (B[i] > maxElement)
                    {
                        maxElement = B[i];
                    }

                    sumBMemory[i] = sum;
                }
            }


            if (minSum == 0 || sum < minSum)
            {
                minSum = sum;
                elementToSum[sum] = maxElement;
            }
        }

        return elementToSum[minSum];
    }
}